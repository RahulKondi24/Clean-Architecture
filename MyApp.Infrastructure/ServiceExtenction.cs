using Microsoft.Extensions.DependencyInjection;
using MyApp.Application.Repositories;
using MyApp.Infrastructure.Repositories;

namespace MyApp.Infrastructure
{
    public static class ServiceExtenction
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
