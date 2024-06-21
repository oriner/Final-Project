using System.ComponentModel.DataAnnotations;

namespace BloodBankingSystem.Models
{
    public class Donor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [Phone]
        public required string PhoneNumber { get; set; }
        public required string Contact { get; set; }

        [Required]
        [StringLength(3)]
        public required string BloodType { get; set; }

        [Required]
        [StringLength(200)]
        public required string Address { get; set; }
    }
}
