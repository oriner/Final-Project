using System.Threading.Tasks;
using BloodBankingSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace BloodBankingSystem.Services
{
    public class UserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(ApplicationUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            return result;
        }
    }
}
