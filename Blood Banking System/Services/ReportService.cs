// Services/ReportService.cs
using System.Net.Http;
using System.Threading.Tasks;

namespace BloodBankingSystem.Services
{
    public class ReportService
    {
        private readonly HttpClient _httpClient;

        public ReportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GenerateReportAsync()
        {
            var response = await _httpClient.GetAsync("http://127.0.0.1:5000/api/report");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
