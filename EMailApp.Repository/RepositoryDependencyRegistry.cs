using EMailApp.Common;
using EMailApp.Common.Extensions;
using EMailApp.Common.Setting;
using EMailApp.Repository.Entity;
using EMailApp.Repository.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EMailApp.Repository
{
    public static class RepositoryDependencyRegistry
    {
        public static void RegisterDependency(IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton<IRepositoryFactory, RepositoryFactory>();

            services.AddTransient<IUnitOfWork, EmailAppDbContext>(provider =>
                new EmailAppDbContext(
                    provider.GetService<IRepositoryFactory>(),
                    new DbContextOptionsBuilder<EmailAppDbContext>().UseSqlServer(appSettings.ConnectionString).Options,
                    provider.GetService<ApplicationContext>()));

            services.AddRepository<IRepository<User>, Repository<User>>();
            services.AddRepository<IRepository<Mail>, Repository<Mail>>();
        }
    }
}
