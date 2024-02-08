using Newtonsoft.Json;
using Weather.Core.Application.Dtos;

namespace Weather.Core.Application;

public class GismeteoService : IDisposable
{
    public GismeteoService(Domain.ExternalApi gismeteo) => _gismeteo = gismeteo;
    
    public async Task<GismeteoWeatherGeneralDto> GetGeneralWeatherAsync(double latitude, double longitude)
    {
        var serializedJson = await _gismeteo.SendGetAsync($"latitude={latitude}&longitude={longitude}");

        var z = new JsonSerializerSettings
        {
            DateFormatString = "yyyy'-'MM'-'dd' 'HH':'mm':'ss"
        }
        
        var definition
        
        var deserializedJson = JsonConvert.DeserializeAnonymousType();
    }
    
    public void Dispose() => _gismeteo.Dispose();

    private readonly Domain.ExternalApi _gismeteo;
}
