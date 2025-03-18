using Services.Interfaces;
using Services;

namespace HealthcareWebApi
{
    public static class DependencyInjectionExtraction
    {
        public static void ConfigureServices(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IUserService, UserService>();

            services.AddTransient<IJwtService, JwtService>();
            
            services.ConfigureRepositires(connectionString);
        }

    }
}
