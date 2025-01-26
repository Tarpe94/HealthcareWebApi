using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Models.Context;

namespace Repository
{
    public static class DependencyInjectionExtraction
    {
        public static void ConfigureRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EntityContext>(options =>
            {
                options.UseNpgsql(connectionString, o => o.SetPostgresVersion(17, 0));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            });
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}

