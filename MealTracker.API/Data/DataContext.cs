using MealTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MealTracker.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
            public DbSet<Meal> Meals { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Favorite> Favorites { get; set; }
        
    }
}