using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Core.IRepositories
{
    public interface ITeamRepository
    {
        Task AddTeamAsync(Team team);

        Task<IEnumerable<Team>> GetTeamsAsync();

        Task<Team> GetTeamByIdAsync(int id);

        Task<Team> GetTeamDetailsAsync(int id);

        void DeleteTeam(Team team);
    }
}
