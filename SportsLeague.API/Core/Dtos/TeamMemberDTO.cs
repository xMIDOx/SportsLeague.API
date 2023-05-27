namespace SportsLeague.API.Core.Dtos
{
    public class TeamMemberDTO
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public byte Number { get; set; }
    }
}
