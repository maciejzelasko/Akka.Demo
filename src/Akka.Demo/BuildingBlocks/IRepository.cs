using System.Threading.Tasks;

namespace Akka.Demo.BuildingBlocks
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
    }
}
