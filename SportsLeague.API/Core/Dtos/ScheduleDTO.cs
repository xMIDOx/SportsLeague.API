namespace SportsLeague.API.Core.Dtos
{
    public class ScheduleDTO
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public string? HomeTeamName { get; set; }
        public int AwayTeamId { get; set; }
        public string? AwayTeamName { get; set; }        
        public DateTime ScheduleDate { get; set; }               
    }
}
