using System;
using System.Threading.Tasks;

namespace EMailApp.Common
{
    public interface IUnitOfWork
    {
        ApplicationContext ApplicationContext { get; }

        int ActiveTransactionCount { get; }

        bool SuppressSoftDeleteFilters { get; }

        bool IsInValidState();

        void EnforceBeginTransaction();

        ITransactionScope BeginTransaction(bool suppressISoftDeleteFilter = false);

        void EndTransaction(string transactionId);

        T GetRepository<T>() where T : IRepository;

        int Save();

        Task<int> SaveAsync();
    }
}
