using Microsoft.Extensions.DependencyInjection;
using MyApp.Application.Repositories;
using MyApp.Application.Services.Implementations;
using MyApp.Application.Services.Interfaces;

namespace MyApp.Application
{
    public static class ServiceExtenction
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
