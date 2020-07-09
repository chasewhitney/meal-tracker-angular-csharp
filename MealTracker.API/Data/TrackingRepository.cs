using System.Threading.Tasks;
using MealTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MealTracker.API.Data
{
    public class TrackingRepository : ITrackingRepository
    {
        private readonly DataContext _context;
        public TrackingRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Goal> GetGoals(int id)
        {
            var goals = await _context.Goals.FirstOrDefaultAsync(g => g.Id == id);

            return goals;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}