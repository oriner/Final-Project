using BloodBankingSystem.Models;
using BloodBankingSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace BloodBankingSystem.Controllers
{
    public class BloodRequestsController : Controller
    {
        private readonly BloodRequestService _bloodRequestService;

        public BloodRequestsController(BloodRequestService bloodRequestService)
        {
            _bloodRequestService = bloodRequestService;
        }

        // GET: BloodRequest/Request
        [HttpGet]
        public IActionResult Requests()
        {
            return View();
        }

        // POST: BloodRequest/Request
        [HttpPost]
        public async Task<IActionResult> Requests(BloodRequest bloodRequest)
        {
            if (ModelState.IsValid)
            {
                await _bloodRequestService.AddBloodRequestAsync(bloodRequest);
                return RedirectToAction("Index", "Home");
            }
            return View(bloodRequest);
        }
    }
}
