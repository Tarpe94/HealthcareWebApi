
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Services.Interfaces;

namespace Services
{
    public static class DependencyInjectoinExtraction
    {
        public static void ConfigureServices(this IServiceCollection services, string connectionString)
        {
            services.ConfigureRepositories(connectionString);
            services.AddScoped<IUserService, UserService>();

        }
    }
}
