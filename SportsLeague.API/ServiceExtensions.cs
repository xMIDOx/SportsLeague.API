using Microsoft.EntityFrameworkCore;
using SportsLeague.API.Core;
using SportsLeague.API.Core.IRepositories;
using SportsLeague.API.Persistence;
using SportsLeague.API.Persistence.Repositories;

namespace SportsLeague.API
{
    public static class ServiceExtensions
    {
        public static void ConfigureConnectionString(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<SportsLeagueDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SportsLeageContext")));
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureAppServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfwork, UnitOfWork>();            

            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
        }
    }
}
