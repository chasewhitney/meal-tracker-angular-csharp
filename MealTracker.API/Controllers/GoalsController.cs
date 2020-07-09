using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using MealTracker.API.Data;
using MealTracker.API.Dtos;
using MealTracker.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MealTracker.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GoalsController : ControllerBase
    {
        private readonly ITrackingRepository _repo;
        private readonly IMapper _mapper;

        public GoalsController(ITrackingRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetGoals()
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var goal = await _repo.GetGoals(userId);

            var goalToReturn = _mapper.Map<GoalForDisplayDto>(goal);

            return Ok(goalToReturn);
        }
    }
}