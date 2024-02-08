using Newtonsoft.Json;

namespace Weather.Core.Application.Jsons;

// Response to a correct request at the URL: https://api.gismeteo.net/v2/weather/current
// Documentation URL: https://www.gismeteo.ru/api/
public class GismeteoResponseJson
{
    [JsonProperty("meta")]
    public GismeteoResponseMeta? Meta { get; set; }
    
    [JsonProperty("response")]
    public GismeteoResponseBody? Body { get; set; }
}

public class GismeteoResponseMeta
{
    [JsonProperty("message")]
    public string? Message { get; set; }
    
    [JsonProperty("code")]
    public string? Code { get; set; }
}

public class GismeteoResponseBody
{
    [JsonProperty("precipitation")]
    public GismeteoResponseBodyPrecipitation? Precipitation { get; set; }
    
    [JsonProperty("pressure")]
    public GismeteoResponseBodyPressure? Pressure { get; set; }
}

public class GismeteoResponseBodyPrecipitation
{
    [JsonProperty("type_ext")]
    public double? TypeExt { get; set; }
    
    [JsonProperty("intensity")]// Documented
    public double? Intensity { get; set; }
    
    //[JsonProperty("correction")] Not sure about the type
    //public double? Correction { get; set; }
    
    [JsonProperty("amount")]// Documented
    public double? Amount { get; set; }
    
    [JsonProperty("duration")]
    public double? Duration { get; set; }
    
    [JsonProperty("type")]// Documented
    public double? Type { get; set; }
}

public class GismeteoResponseBodyPressure
{
    [JsonProperty("h_pa")]
    public double? HPa { get; set; }
    
    [JsonProperty("mm_hg_atm")]// Documented
    public double? AtmosMillimetersOfMercury { get; set; }
    
    [JsonProperty("in_hg")]
    public double? InHg { get; set; }
}