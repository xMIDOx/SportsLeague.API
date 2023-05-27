using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsLeague.API.Core;
using SportsLeague.API.Core.Dtos;
using SportsLeague.API.Core.IRepositories;
using SportsLeague.API.Core.Models;
using System.Net.Http.Headers;

namespace SportsLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleRepository _ScheduleRepo;
        private readonly IUnitOfwork _unitOfWork;
        private readonly IMapper _mapper;


        public ScheduleController(IScheduleRepository scheduleRepo, IUnitOfwork unitOfWork, IMapper mapper)
        {
            _ScheduleRepo = scheduleRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ScheduleDTO scheduleDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var schedule = _mapper.Map<ScheduleDTO, Schedule>(scheduleDTO);

            await _ScheduleRepo.AddSchedualeAsync(schedule);

            await _unitOfWork.CompleteAsync();

            return Ok(_mapper.Map<Schedule, ScheduleDTO>(schedule));
        }
    }
}
