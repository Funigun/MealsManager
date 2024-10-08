using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MealsManager.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MealsManagerDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MealsManager"));
            });

            return services;
        }
    }
}
