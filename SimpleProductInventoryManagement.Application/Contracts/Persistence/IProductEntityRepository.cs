using SimpleProductInventoryManagement.Domain;

namespace SimpleProductInventoryManagement.Application.Contracts.Persistence
{
    public interface IProductEntityRepository: IGenericRepository<ProductEntity>
    {
        Task<bool> IsProductNameUnique(string productName);
    }
}
