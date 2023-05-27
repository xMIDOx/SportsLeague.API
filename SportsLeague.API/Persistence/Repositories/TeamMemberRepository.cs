using SportsLeague.API.Core.IRepositories;
using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Persistence.Repositories
{
    public class TeamMemberRepository : ITeamMemberRepository
    {
        private readonly SportsLeagueDbContext _context;

        public TeamMemberRepository(SportsLeagueDbContext context)
        {
            _context = context;
        }

        public async Task AddTeamMemberAsync(TeamMember teamMember)
        {
            await _context.TeamMembers.AddAsync(teamMember);
        }
    }
}
