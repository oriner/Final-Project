using Microsoft.AspNetCore.Identity;

namespace BloodBankingSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string BloodType { get; set; }
        public required string Address { get; set; }
    }
}
