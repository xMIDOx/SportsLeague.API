using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsLeague.API.Core;
using SportsLeague.API.Core.Dtos;
using SportsLeague.API.Core.IRepositories;
using SportsLeague.API.Core.Models;
using System.Collections.Generic;

namespace SportsLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamRepository _teamRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfwork _unitOfWork;

        public TeamController(ITeamRepository teamRepo, IMapper mapper, IUnitOfwork unitOfWork)
        {
            _teamRepo = teamRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetTeams()
        {
            var teams = await _teamRepo.GetTeamsAsync();

            return Ok(_mapper.Map<IEnumerable<Team>, IEnumerable<TeamDTO>>(teams));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetTeamDetails(int id)
        {
            var team = await _teamRepo.GetTeamDetailsAsync(id);
            if (team == null) return NotFound();

            return Ok(_mapper.Map<Team, TeamDetailsDTO>(team));

        }

        [HttpPost]
        public async Task<IActionResult> Create(TeamDTO teamDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var team = _mapper.Map<TeamDTO, Team>(teamDTO);

            await _teamRepo.AddTeamAsync(team);

            await _unitOfWork.CompleteAsync();

            return Ok(team.Id);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, TeamDTO teamDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var team = await _teamRepo.GetTeamByIdAsync(id);
            if (team == null) return NotFound();

            _mapper.Map(teamDTO, team);

            await _unitOfWork.CompleteAsync();

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var team = await _teamRepo.GetTeamByIdAsync(id);
            if (team == null) return NotFound();

            _teamRepo.DeleteTeam(team);

            await _unitOfWork.CompleteAsync();

            return Ok();
        }
    }
}
