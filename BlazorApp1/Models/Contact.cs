using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
	public class Contact
	{
        [ValidateNever]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }

    }
}
