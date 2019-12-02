using Microsoft.Extensions.DependencyInjection;

namespace WebStore.Application
{
    public static class IoCContainer
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
    
}
