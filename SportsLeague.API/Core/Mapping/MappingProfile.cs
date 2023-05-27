using AutoMapper;
using SportsLeague.API.Core.Dtos;
using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region  Model to DTO  (s >> Source, d >> Destination)
            CreateMap<Team, TeamDTO>();
            CreateMap<Team, TeamDetailsDTO>();
            CreateMap<TeamMember, TeamMemberDTO>();
            
            CreateMap<Schedule, ScheduleDTO>()
                .ForMember(d => d.HomeTeamName, opt => opt.MapFrom(s => s.HomeTeam.Name))
                .ForMember(d => d.AwayTeamName, opt => opt.MapFrom(s => s.AwayTeam.Name));
            #endregion

            #region DTO to Model (s >> Source, d >> Destination)            
            CreateMap<TeamDTO, Team>().ForMember(d => d.Id, opt => opt.Ignore());
            CreateMap<TeamMemberDTO, TeamMember>().ForMember(d => d.Id, opt => opt.Ignore());
            CreateMap<ScheduleDTO, Schedule>().ForMember(d => d.Id, opt => opt.Ignore());
            #endregion
        }
    }
}
