using Weather.Core.Application.Dtos;
using Weather.Core.Application.Interfaces.Converters;
using Weather.Core.Application.Jsons;

namespace Weather.Core.Application.Implementations.Converters;

public class JsonToDtoConverter : IJsonToDtoConverter
{
    public GismeteoWeatherGeneralDto GismeteoResponseToWeatherGeneral(GismeteoResponseJson responseJson) =>
        new GismeteoWeatherGeneralDto()
        {
            Status = responseJson.Body?.Status ?? string.Empty,
            DataDateTime = responseJson.Body?.DataDate?.Utc ?? default,
            AirTemperatureInCelsius = responseJson.Body?.Temperature?.Air?.DegreesCelcius ?? default,
            FeelingTemperatureInCelsius = responseJson.Body?.Temperature?.Comfort?.DegreesCelcius ?? default,
            Description = responseJson.Body?.Description?.Full ?? string.Empty
        };
}