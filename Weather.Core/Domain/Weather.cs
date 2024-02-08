namespace Weather.Core.Domain;

public class Weather : IDisposable
{
    public Weather(Uri rootUrl, string token, IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
        _httpClient.BaseAddress = rootUrl;
        _httpClient.DefaultRequestHeaders.Add("X-Gismeteo-Token", token);
    }

    public async Task<string> GetWeatherAsync(double latitude, double longitude)
    {
        if (latitude < -90 || latitude > 90 || longitude < -180 || longitude > 180)
            throw new Exception("Latitude and longitude values must lie in the intervals [-90;90] and" +
                                "[-180;180] respectively");
        
        using var request = new HttpRequestMessage(HttpMethod.Get,
            $"?latitude={latitude}&longitude={longitude}");
        
        using var response = await _httpClient.SendAsync(request);

        return await response.Content.ReadAsStringAsync();
    }
    
    public void Dispose() => _httpClient.Dispose();

    private readonly HttpClient _httpClient;
}