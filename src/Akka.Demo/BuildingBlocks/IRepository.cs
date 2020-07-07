using System.Threading.Tasks;

namespace Akka.Demo.BuildingBlocks
{
    using System;

    public interface IRepository<T>
    {
        Task AddAsync(T entity);

        Task<T> GetByIdAsync(Guid id);
    }
}
