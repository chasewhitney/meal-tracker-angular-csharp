using System.Threading.Tasks;
using MealTracker.API.Models;

namespace MealTracker.API.Data
{
    public interface ITrackingRepository
    {
        void Add<T>(T entity) where T: class;

        void Delete<T>(T entity) where T: class;

        Task<Goal> GetGoals(int id);
        Task<bool> SaveAll();
    }
}