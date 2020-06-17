using System;

namespace MealTracker.API.Models
{
    public class Meal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int UserId { get; set; }

        public int Calories { get; set; }

        public int Fat { get; set; }

        public int Protein { get; set; }

        public int NetCarbs { get; set; }

        public DateTime Date { get; set; }
    }
}