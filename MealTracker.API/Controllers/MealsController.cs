using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealTracker.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MealTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private DataContext _context;

        public MealsController(DataContext context) {

            this._context = context;
        }

        // GET api/meals
        [HttpGet]
        public async Task<IActionResult> GetMeals()
        {
            var meals = await _context.Meals.ToListAsync();

            return Ok(meals);
        }

        
    }
}
