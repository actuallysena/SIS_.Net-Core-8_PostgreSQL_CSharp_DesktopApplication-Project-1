using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Interfaces;
using BusinessLogicLayer.Services;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ObsDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddScoped<LoginService>();

            return services;
        }
    }
}
