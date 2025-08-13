using Microsoft.EntityFrameworkCore;
using SimpleProductInventoryManagement.Application.Contracts.Persistence;
using SimpleProductInventoryManagement.Domain;
using SimpleProductInventoryManagement.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Persistence.Repositories
{
    public class ProductEntityRepository : GenericRepository<ProductEntity>, IProductEntityRepository
    {
        public ProductEntityRepository(ProductDatabaseContext context) : base(context)
        {
        }

        public async Task<bool> IsProductNameUnique(string productName)
        {
            return await _context.Products.AnyAsync(p => p.Name == productName) == false;
        }
    }
}
