using BlazorApp.Logic.Entities;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Logic.Models
{
    public class RegisterClientDto : Entity
    {
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please provide last name")]
        [MinLength(2)]
        [MaxLength(28)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string? Nationality { get; set; }
        public DateTime? DataOfBirth { get; set; }
        public int RoleId { get; set; } = 1;
    }
}
