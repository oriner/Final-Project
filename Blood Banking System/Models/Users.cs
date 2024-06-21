using System.ComponentModel.DataAnnotations;

namespace BloodBankingSystem.Models
{
    public class User
    {
        [Key]
        public required string Id { get; set; } 

        [Required]
        public required string Username { get; set; }

        [Required]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; } 

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required]
        public required string PhoneNumber { get; set; }

        [Required]
        public required string BloodType { get; set; }

        [Required]
        public required string Address { get; set; }
    }
}
