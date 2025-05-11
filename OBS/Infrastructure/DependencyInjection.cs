using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Interfaces; 

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ObsDbContext>(options =>
                options.UseNpgsql(connectionString));


            // Generic Repository içinn
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

            // Service için kayit
            services.AddScoped<ILoginService, LoginService>();

            return services;
        }
    }
}
