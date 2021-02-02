using EMailApp.Common;
using EMailApp.Repository.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EMailApp.Repository.Entity
{
    public partial class EmailAppDbContext : IUnitOfWork
    {
        private readonly IRepositoryFactory repositoryFactory;
        private bool shouldBeginTransaction;
        private bool isInTransaction;
        private bool isInValidState = true;
        private Stack<string> transactionStack = new Stack<string>();
        private readonly ApplicationContext applicationContext;

        public int ActiveTransactionCount
        {
            get
            {
                return transactionStack.Count;
            }
        }

        public bool SuppressSoftDeleteFilters { get; private set; }

        public ApplicationContext ApplicationContext => this.applicationContext;

        public EmailAppDbContext(IRepositoryFactory repositoryFactory, DbContextOptions<EmailAppDbContext> options, ApplicationContext applicationContext)
            : this(options)
        {
            this.repositoryFactory = repositoryFactory;
            this.applicationContext = applicationContext;
        }

        public bool IsInValidState()
        {
            return this.isInValidState;
        }

        public void EnforceBeginTransaction()
        {
            shouldBeginTransaction = true;
        }

        public ITransactionScope BeginTransaction(bool suppressISoftDeleteFilter = false)
        {
            // We consider the suppress filter only for outer scope
            if (this.ActiveTransactionCount == 0)
            {
                this.SuppressSoftDeleteFilters = suppressISoftDeleteFilter;
            }

            isInTransaction = true;
            var transactionScope = new TransactionScope(this);
            transactionStack.Push(transactionScope.TransactionId);

            return transactionScope;
        }

        public void EndTransaction(string transactionId)
        {
            var topTransactionId = transactionStack.Pop();
            if (topTransactionId != transactionId)
            {
                throw new Exception("The transaction scopes are malfunctioned. Ensure that the nested transactions are last in first out order.");
            }

            // Reset the suppress filter when going out from the outer scope
            if (this.ActiveTransactionCount == 0)
            {
                this.SuppressSoftDeleteFilters = false;
            }
        }

        public T GetRepository<T>() where T : IRepository
        {
            return this.repositoryFactory.CreateInstance<T>(this);
        }

        public int Save()
        {
            if (this.ValidateSave())
            {
                return this.SaveChanges();
            }

            return -1;
        }

        public async Task<int> SaveAsync()
        {
            if (this.ValidateSave())
            {
                return await this.SaveChangesAsync();
            }

            return -1;
        }

        public override int SaveChanges()
        {
            this.Audit();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Audit();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.Audit();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Audit();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void Audit()
        {
            var modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified).ToList();
            var addedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added).ToList();

            foreach (var entry in modifiedEntries)
            {
                if (entry is IAuditable auditable)
                {
                    auditable.UpdatedBy = this.applicationContext.UserId;
                    auditable.UpdatedOn = DateTime.UtcNow;
                }
            }

            foreach (var entry in addedEntries)
            {
                if (entry.Entity is IAuditable auditable)
                {
                    auditable.CreatedBy = auditable.UpdatedBy = this.applicationContext.UserId;

                    if (auditable.CreatedOn == default(DateTime))
                    {
                        // If the date is default, then set curent date
                        auditable.CreatedOn = DateTime.UtcNow;
                    }
                    else
                    {
                        // Set already existing created date as modified date.
                        auditable.UpdatedOn = auditable.CreatedOn;
                    }
                }
            }
        }

        private bool ValidateSave()
        {
            if (shouldBeginTransaction && !isInTransaction)
            {
                this.isInValidState = false;
                throw new Exception("An unit of work transaction must be initiated and the save should be called on generated transaction scope object.");
            }

            if (shouldBeginTransaction && isInTransaction)
            {
                return false;
            }

            return true;
        }
    }
}
