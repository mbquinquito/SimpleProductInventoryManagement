
using SimpleProductInventoryManagement.Models;
using SimpleProductInventoryManagement.Services.Base;

namespace SimpleProductInventoryManagement.Contracts
{
    public interface IProductEntityService
    {
        Task<List<ProductEntityVM>> GetProductEntities();
        Task<ProductEntityVM> GetProductDetails(int id);
        Task<Response<Guid>> CreateProductEntity(ProductEntityVM productEntity);
        Task<Response<Guid>> UpdateProductEntity(int id, ProductEntityVM productEntity);
        Task<Response<Guid>> DeleteProductEntity(int id);
    }
}
