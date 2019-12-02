using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebStore.Persistence.DbContext;

namespace WebStore.Persistence
{
    public static class InversionOfControlContainer
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("WebStoreDatabase");

            services.AddDbContext<StoreDbContext>(options =>
                options.UseLazyLoadingProxies().UseSqlServer(connectionString));
            
            return services;
        }
    }
}
