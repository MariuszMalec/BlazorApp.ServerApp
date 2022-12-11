using BlazorApp.Logic.Entities;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Logic.Models
{
    public class UserView : Entity
    {

        [Required(ErrorMessage = "Please enter first name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide last name")]
        [StringLength(25)]
        public string LastName { get; set; }
    }
}
