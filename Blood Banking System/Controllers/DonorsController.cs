using BloodBankingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BloodBankingSystem.Controllers
{
    public class DonorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonorController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Donor donor)
        {
            if (ModelState.IsValid)
            {
                _context.Donors.Add(donor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(donor);
        }
    }
}
