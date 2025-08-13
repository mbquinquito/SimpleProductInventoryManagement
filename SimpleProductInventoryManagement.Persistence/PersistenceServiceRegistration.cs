using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleProductInventoryManagement.Application.Contracts.Persistence;
using SimpleProductInventoryManagement.Persistence.DatabaseContext;
using SimpleProductInventoryManagement.Persistence.Repositories;

namespace SimpleProductInventoryManagement.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductDatabaseContext>(options =>
            {
                options.UseMySql(
                    configuration.GetConnectionString("ProductDatabaseConnectionString"),
                    ServerVersion.AutoDetect(configuration.GetConnectionString("ProductDatabaseConnectionString"))
                );
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductEntityRepository, ProductEntityRepository>();
            return services;
        }
    }
}
