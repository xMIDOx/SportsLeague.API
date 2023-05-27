using SportsLeague.API.Core.IRepositories;
using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Persistence.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly SportsLeagueDbContext _context;

        public ScheduleRepository(SportsLeagueDbContext context)
        {
            _context = context;
        }

        public async Task AddSchedualeAsync(Schedule schedule)
        {
            await _context.Schedules.AddAsync(schedule);
        }
    }
}
