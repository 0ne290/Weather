using Newtonsoft.Json;
using Weather.Core.Application.Dtos;

namespace Weather.Core.Application;

public class WeatherService : IDisposable
{
    public WeatherService(Domain.Weather weather) => _weather = weather;
    
    public async Task<WeatherGeneralDto> GetGeneralWeatherAsync(double latitude, double longitude)
    {
        var serializedJson = await _weather.GetWeatherAsync(latitude, longitude);

        var z = new JsonSerializerSettings
        {
            DateFormatString = "yyyy'-'MM'-'dd' 'HH':'mm':'ss"
        }
        
        var definition
        
        var deserializedJson = JsonConvert.DeserializeAnonymousType();
    }
    
    public void Dispose() => _weather.Dispose();

    private readonly Domain.Weather _weather;
}