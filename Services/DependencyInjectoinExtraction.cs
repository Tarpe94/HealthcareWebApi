
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Services.Interfaces;

namespace Services
{
    public static class DependencyInjectoinExtraction
    {
        public static void ConfigureRepositires(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.ConfigureDatabase(connectionString);
        }
    }
}
