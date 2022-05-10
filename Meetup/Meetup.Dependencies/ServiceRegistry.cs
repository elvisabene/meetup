using Meetup.Business.Services;
using Meetup.Business.Services.Interfaces;
using Meetup.Data;
using Meetup.Data.Repositories;
using Meetup.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meetup.Dependencies
{
    public static class ServiceRegistry
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("Default");
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IEventRepository, EventRepository>();
        }

        public static void AddBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<IEventService, EventService>();
        }
    }
}
