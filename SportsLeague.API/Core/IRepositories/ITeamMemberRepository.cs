using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Core.IRepositories
{
    public interface ITeamMemberRepository
    {
        Task AddTeamMemberAsync(TeamMember teamMember);
    }
}
