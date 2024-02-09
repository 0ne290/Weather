using Weather.Core.Application.Dtos;
using Weather.Core.Application.Jsons;

namespace Weather.Core.Application.Interfaces.Converters;

public interface IJsonToDtoConverter
{
    GismeteoWeatherGeneralDto GismeteoResponseToWeatherGeneral(GismeteoResponseJson responseJson);
}