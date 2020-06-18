using System.ComponentModel.DataAnnotations;

namespace MealTracker.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "You must specify a password between 3 and 15 characters")]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}