using Microsoft.EntityFrameworkCore;
using SimpleProductInventoryManagement.Domain;
using SimpleProductInventoryManagement.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Persistence.DatabaseContext
{
    public class ProductDatabaseContext : DbContext
    {
        public ProductDatabaseContext(DbContextOptions<ProductDatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductDatabaseContext).Assembly);
            modelBuilder.Entity<ProductEntity>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                      .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                      .HasColumnType("datetime");

            });
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<ProductEntity>().Where(entry => entry.State == EntityState.Added || entry.State == EntityState.Modified))
            {
                entry.Entity.UpdatedAt = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
