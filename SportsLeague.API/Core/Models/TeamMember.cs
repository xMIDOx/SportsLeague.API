namespace SportsLeague.API.Core.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public byte Number { get; set; }

        public Team Team { get; set; }
    }
}
