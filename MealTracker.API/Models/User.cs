using System.Collections.Generic;

namespace MealTracker.API.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Meal> Meals { get; set; }

        public Goal Goals { get; set; }
    }
}