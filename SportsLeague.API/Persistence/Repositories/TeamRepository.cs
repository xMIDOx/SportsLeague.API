using Microsoft.EntityFrameworkCore;
using SportsLeague.API.Core.IRepositories;
using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Persistence.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly SportsLeagueDbContext _context;

        public TeamRepository(SportsLeagueDbContext context)
        {
            _context = context;
        }

        public async Task AddTeamAsync(Team team)
        {
            await _context.Teams.AddAsync(team);
        }

        public async Task<IEnumerable<Team>> GetTeamsAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> GetTeamByIdAsync(int id)
        {
            return await _context.Teams.FindAsync(id);
        }

        public async Task<Team> GetTeamDetailsAsync(int id)
        {
            return await _context.Teams
                .Include(t => t.TeamMembers)                
                .Include(t => t.HomeSchedules)  
                .ThenInclude(s => s.AwayTeam)
                .Include(t => t.AwaySchedules)
                .ThenInclude(s => s.HomeTeam)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public void DeleteTeam(Team team)
        {
            _context.Teams.Remove(team);
        }
    }
}
