// Controllers/ReportController.cs
using Microsoft.AspNetCore.Mvc;
using BloodBankingSystem.Services;
using System.Threading.Tasks;

namespace BloodBankingSystem.Controllers
{
    public class ReportController : Controller
    {
        private readonly ReportService _reportService;

        public ReportController(ReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        public async Task<IActionResult> GenerateReport()
        {
            var result = await _reportService.GenerateReportAsync();
            return Ok(result);
        }
    }
}
