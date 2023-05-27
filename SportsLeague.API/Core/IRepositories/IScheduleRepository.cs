using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Core.IRepositories
{
    public interface IScheduleRepository
    {
        Task AddSchedualeAsync(Schedule schedule);
    }
}
