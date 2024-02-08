namespace Weather.Core.Domain;

public class ExternalApi : IDisposable
{
    public Weather(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<string> SendGetAsync(string parameters)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, parameters);
        
        using var response = await _httpClient.SendAsync(request);

        return await response.Content.ReadAsStringAsync();
    }
    
    public void Dispose() => _httpClient.Dispose();

    private readonly HttpClient _httpClient;
}
