using System.ComponentModel.DataAnnotations;

namespace BloodBankingSystem.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public required string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public required string ConfirmPassword { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public required string LastName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public required string PhoneNumber { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "Blood Type")]
        public required string BloodType { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Address")]
        public required string Address { get; set; }
    }
}
