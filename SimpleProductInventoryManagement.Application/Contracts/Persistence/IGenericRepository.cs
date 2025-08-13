using SimpleProductInventoryManagement.Domain;

namespace SimpleProductInventoryManagement.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : ProductEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync(); 
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
