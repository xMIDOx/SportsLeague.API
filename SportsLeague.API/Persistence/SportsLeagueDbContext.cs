using Microsoft.EntityFrameworkCore;
using SportsLeague.API.Core.Models;
using System.Reflection;

namespace SportsLeague.API.Persistence
{
    public class SportsLeagueDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public SportsLeagueDbContext(DbContextOptions<SportsLeagueDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
