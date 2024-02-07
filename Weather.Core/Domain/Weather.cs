namespace Weather.Core.Domain;

public class Weather : IDisposable
{
    public Weather(Uri rootUrl, string token, IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
        _httpClient.BaseAddress = rootUrl;
        _httpClient.DefaultRequestHeaders.Add("X-Gismeteo-Token", token);
    }

    public string GetWeather(double latitude, double longitude)
    {
        if (latitude < -90 || latitude > 90 || longitude < -180 || longitude > 180)
            throw new Exception("Latitude and longitude values must lie in the intervals [-90;90] and" +
                                "[-180;180] respectively");
        
        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,
            $"?latitude={latitude}&longitude={longitude}");
        
        
    }
    
    public void Dispose() => _httpClient.Dispose();

    private HttpClient _httpClient;
}