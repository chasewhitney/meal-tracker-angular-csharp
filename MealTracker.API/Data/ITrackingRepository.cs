using System.Threading.Tasks;

namespace MealTracker.API.Data
{
    public interface ITrackingRepository
    {
        void Add<T>(T entity) where T: class;

        void Delete<T>(T entity) where T: class;

        Task<bool> SaveAll();
    }
}