using System.Collections.ObjectModel;

namespace SportsLeague.API.Core.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Coach { get; set; }

        public IEnumerable<TeamMember> TeamMembers { get; set; }
        public IEnumerable<Schedule> HomeSchedules { get; set; }
        public IEnumerable<Schedule> AwaySchedules { get; set; }

        public Team()
        {
            TeamMembers = new Collection<TeamMember>();
            HomeSchedules = new Collection<Schedule>();
            AwaySchedules = new Collection<Schedule>();
        }
    }
}
