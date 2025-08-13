using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleProductInventoryManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Persistence.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasData(
                new ProductEntity
                {
                    Id = 1,
                    Name = "Sample Product",
                    Description = "This is a sample product description.",
                    Price = 19.99m,
                    Quantity = 100,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
            builder.Property(p => p.Price)
               .HasPrecision(10, 2);

            builder.Property(p => p.Name)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(p => p.Description)
               .HasColumnType("TEXT");

        }
    }
}
