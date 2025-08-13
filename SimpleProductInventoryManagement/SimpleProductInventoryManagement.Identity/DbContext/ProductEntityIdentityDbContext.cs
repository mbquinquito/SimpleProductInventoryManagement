using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleProductInventoryManagement.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Identity.DbContext
{
    public class ProductEntityIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public ProductEntityIdentityDbContext(DbContextOptions<ProductEntityIdentityDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ProductEntityIdentityDbContext).Assembly);
        }
    }
}
