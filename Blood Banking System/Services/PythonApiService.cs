using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class PythonApiService
{
    private readonly HttpClient _httpClient;

    public PythonApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T?> GetFromPythonApiAsync<T>(string endpoint) where T : class
    {
        var response = await _httpClient.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(responseString);
    }

    
}
