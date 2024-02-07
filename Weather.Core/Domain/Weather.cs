namespace Weather.Core.Domain;

public class Weather
{
    public Weather(Uri rootUrl, string token, IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
        _httpClient.BaseAddress = rootUrl;
        _httpClient.DefaultRequestHeaders.Add("X-Gismeteo-Token", token);
    }

    private HttpClient _httpClient;
}