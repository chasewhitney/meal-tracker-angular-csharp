namespace MealTracker.API.Models
{
    public class Favorite
    {       
        public int Id { get; set; }

        public string Name { get; set; }

        public int Calories { get; set; }

        public int Fat { get; set; }

        public int Protein { get; set; }

        public int NetCarbs { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }
        
    }
}