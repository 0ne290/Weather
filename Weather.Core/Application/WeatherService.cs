using Weather.Core.Application.Dtos;

namespace Weather.Core.Application;

public class WeatherService
{
    public WeatherService(Domain.Weather weather) => _weather = weather;
    
    public WeatherGeneralDto GetGeneralWeather(double latitude, double longitude)
    {
        
    }

    private Domain.Weather _weather;
}