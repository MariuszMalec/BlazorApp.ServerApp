using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Logic.Models
{
    public class LoginClientDto
    {
        [Required(ErrorMessage = "Please provide last name")]
        [MinLength(2)]
        [MaxLength(28)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
