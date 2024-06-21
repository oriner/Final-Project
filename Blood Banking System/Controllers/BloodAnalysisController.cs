using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class BloodAnalysisController : Controller
{
    private readonly PythonApiService _pythonApiService;

    public BloodAnalysisController(PythonApiService pythonApiService)
    {
        _pythonApiService = pythonApiService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAnalysis()
    {
        var result = await _pythonApiService.GetFromPythonApiAsync<object>("http://127.0.0.1:5000/data_analysis");
        return View(result);
    }
}
