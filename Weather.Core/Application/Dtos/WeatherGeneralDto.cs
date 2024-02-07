namespace Weather.Core.Application.Dtos;

public class WeatherGeneralDto
{
    public string Status { get; init; } = string.Empty;
    
    public DateTime DataDateTime { get; init; }
    
    public double AirTemperatureInCelsius { get; set; }
    
    public double FeelingTemperatureInCelsius { get; set; }
    
    public string Description { get; init; } = string.Empty;
}