using SportsLeague.API.Core.Models;
using System.Collections.ObjectModel;

namespace SportsLeague.API.Core.Dtos
{
    public class TeamDetailsDTO
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Coach { get; set; }

        public IEnumerable<TeamMemberDTO> TeamMembers { get; set; }
        public IEnumerable<ScheduleDTO> HomeSchedules { get; set; }
        public IEnumerable<ScheduleDTO> AwaySchedules { get; set; }

        public TeamDetailsDTO()
        {
            TeamMembers = new Collection<TeamMemberDTO>();
            HomeSchedules = new Collection<ScheduleDTO>();
            AwaySchedules = new Collection<ScheduleDTO>();
        }
    }
}
