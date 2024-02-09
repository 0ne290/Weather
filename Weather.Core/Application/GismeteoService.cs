using Newtonsoft.Json;
using Weather.Core.Application.Dtos;
using Weather.Core.Application.Interfaces;
using Weather.Core.Application.Interfaces.Converters;
using Weather.Core.Application.Jsons;
using Weather.Core.Domain.Interfaces;

namespace Weather.Core.Application;

public class GismeteoService : IDisposable
{
    public GismeteoService(IExternalApiFactory factory, IJsonToDtoConverter converter)
    {
        _gismeteo = factory.FactoryMethod();
        _converter = converter;
    }
    
    public async Task<GismeteoWeatherGeneralDto> GetGeneralWeatherAsync(double latitude, double longitude)
    {
        if (latitude < -90 || latitude > 90 || longitude < -180 || longitude > 180)
            throw new Exception("Latitude and longitude values must lie in the intervals [-90;90] and" +
                                "[-180;180] respectively");
    
        var serializedJson = await _gismeteo.SendGetAsync($"latitude={latitude}&longitude={longitude}");
        
        var deserializedJson = JsonConvert.DeserializeObject<GismeteoResponseJson>(serializedJson, new
            JsonSerializerSettings { DateFormatString = "yyyy'-'MM'-'dd' 'HH':'mm':'ss" });

        if (deserializedJson == null)
        {
            var exception =
                new Exception("Could not map the response from Gismeteo to the DTO. Check the response from" +
                              "Gismeteo (Exception.Data[\"Response\"]). If the response matches the format in the" +
                              "documentation, then Newtosoft.Json.JsonConvert cannot map that response to an object of" +
                              "the Weather.Core.Application.Jsons.GismeteoResponseJson class - resolve the error in" +
                              "the Weather.Core.Application.Jsons.GismeteoResponseJson.cs file. If the response does" +
                              "not match the format in the documentation, then the HttpClient dependency of the" +
                              "Weather.Core.Domain.Implementations.ExternalApi class is not configured correctly or" +
                              "the Weather.Core.Application.GismeteoService.GetGeneralWeatherAsync method contains an" +
                              "error - fix the error in the composition root or in the method" +
                              "Weather.Core.Application.GismeteoService.GetGeneralWeatherAsync");
            
            exception.Data.Add("Response", serializedJson);

            throw exception;
        }
            
        return _converter.GismeteoResponseToWeatherGeneral(deserializedJson);
    }
    
    public void Dispose() => _gismeteo.Dispose();

    private readonly IExternalApi _gismeteo;

    private readonly IJsonToDtoConverter _converter;
}
