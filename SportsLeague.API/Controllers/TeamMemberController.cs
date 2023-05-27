using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsLeague.API.Core;
using SportsLeague.API.Core.Dtos;
using SportsLeague.API.Core.IRepositories;
using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMemberController : ControllerBase
    {
        private readonly ITeamMemberRepository _teamMemberRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfwork _unitOfWork;

        public TeamMemberController(ITeamMemberRepository teamMemberRepo, IMapper mapper, IUnitOfwork unitOfWork)
        {
            _teamMemberRepo = teamMemberRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Create(TeamMemberDTO teamMemberDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var teamMember = _mapper.Map<TeamMemberDTO, TeamMember>(teamMemberDTO);

            await _teamMemberRepo.AddTeamMemberAsync(teamMember);

            await _unitOfWork.CompleteAsync();

            return Ok(_mapper.Map<TeamMember, TeamMemberDTO>(teamMember));
        }
    }
}
