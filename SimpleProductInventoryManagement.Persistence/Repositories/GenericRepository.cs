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
    public class GenericRepository<T> : IGenericRepository<T> where T : ProductEntity
    {
        protected readonly ProductDatabaseContext _context;

        public GenericRepository(ProductDatabaseContext context)
        {
            this._context = context;
        }

        public async Task CreateAsync(T entity)
        {
            var sql = @"
        INSERT INTO Products (Name, Description, Price, Quantity, CreatedAt, UpdatedAt)
        VALUES ({0}, {1}, {2}, {3}, NOW(), NOW());";

            await _context.Database.ExecuteSqlRawAsync(
                sql,
                entity.Name,
                entity.Description,
                entity.Price,
                entity.Quantity
            );
        }

        public async Task DeleteAsync(T entity)
        {
            var sql = "DELETE FROM Products WHERE Id = {0};";
            await _context.Database.ExecuteSqlRawAsync(sql, entity.Id);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            var sql = "SELECT * FROM Products;";
            return await _context.Set<T>().FromSqlRaw(sql).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id = {0};";
            return await _context.Set<T>().FromSqlRaw(sql, id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            var sql = @"
        UPDATE Products
        SET Name = {0}, Description = {1}, Price = {2}, Quantity = {3}, UpdatedAt = NOW()
        WHERE Id = {4};";

            await _context.Database.ExecuteSqlRawAsync(
                sql,
                entity.Name,
                entity.Description,
                entity.Price,
                entity.Quantity,
                entity.Id
            );
        }
    }
}
