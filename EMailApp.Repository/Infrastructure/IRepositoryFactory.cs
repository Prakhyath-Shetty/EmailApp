using EMailApp.Common;

namespace EMailApp.Repository.Infrastructure
{
    public interface IRepositoryFactory
    {
        TRepository CreateInstance<TRepository>(IUnitOfWork unitOfWork) where TRepository : IRepository;
    }
}
