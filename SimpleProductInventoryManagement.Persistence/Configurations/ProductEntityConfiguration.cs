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
                    Name = "Dragonfruit",
                    Description = "Fruit",
                    Price = 19.99m,
                    Quantity = 100,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new ProductEntity
                {
                    Id = 2,
                    Name = "Grapes",
                    Description = "Fruit",
                    Price = 39.99m,
                    Quantity = 400,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new ProductEntity
                {
                    Id = 3,
                    Name = "Pineapple",
                    Description = "Fruit",
                    Price = 69.99m,
                    Quantity = 900,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }

                ,
                new ProductEntity
                {
                    Id = 4,
                    Name = "Carrots",
                    Description = "Vegetable",
                    Price = 9.99m,
                    Quantity = 200,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
                ,
                new ProductEntity
                {
                    Id = 5,
                    Name = "Onions",
                    Description = "Vegetable",
                    Price = 1.99m,
                    Quantity = 500,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
                ,
                new ProductEntity
                {
                    Id = 6,
                    Name = "Mango",
                    Description = "Fruit",
                    Price = 59.99m,
                    Quantity = 480,
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
