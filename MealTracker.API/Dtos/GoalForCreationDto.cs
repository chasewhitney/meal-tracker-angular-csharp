namespace MealTracker.API.Dtos
{
    public class GoalForCreationDto
    {
        public int MinCalories { get; set; }
        public int MaxCalories { get; set; }
        public int MinFat { get; set; }
        public int MaxFat { get; set; }
        public int MinProtein { get; set; }
        public int MaxProtein { get; set; }
        public int MinCarbs { get; set; }
        public int MaxCarbs { get; set; }

    }
}