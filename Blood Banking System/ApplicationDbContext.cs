using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodBankingSystem.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Donor> Donors { get; set; }
        public DbSet<BloodStorage> BloodStorages { get; set; }
        public DbSet<BloodRequest> BloodRequests { get; set; }
    }
}
