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
    
    [JsonProperty("humidity")]
    public GismeteoResponseBodyHumidity? Humidity { get; set; }
    
    [JsonProperty("icon")]// Documented
    public string? IconName { get; set; }
    
    [JsonProperty("gm")]// Documented
    public string? GeomagneticFieldDisturbanceCoefficient { get; set; }
    
    [JsonProperty("wind")]
    public GismeteoResponseBodyWind? Wind { get; set; }
    
    [JsonProperty("cloudiness")]
    public GismeteoResponseBodyCloudiness? Cloudiness { get; set; }
    
    [JsonProperty("date")]
    public GismeteoResponseBodyDate? DataDate { get; set; }
    
    [JsonProperty("radiation")]
    public GismeteoResponseBodyRadiation? Radiation { get; set; }
    
    [JsonProperty("city")]
    public double? City { get; set; }
    
    [JsonProperty("kind")]// Documented
    public string? Status { get; set; }
    
    [JsonProperty("storm")]// Documented
    public bool? Storm { get; set; }
    
    [JsonProperty("temperature")]
    public GismeteoResponseBodyTemperature? Temperature { get; set; }
    
    [JsonProperty("description")]
    public GismeteoResponseBodyDescription? Description { get; set; }
}

public class GismeteoResponseBodyPrecipitation
{
    [JsonProperty("type_ext")]
    public double? ExtendedTypeCode { get; set; }
    
    [JsonProperty("intensity")]// Documented
    public double? IntensityCoefficient { get; set; }
    
    //[JsonProperty("correction")] Not sure about the type
    //public double? Correction { get; set; }
    
    [JsonProperty("amount")]// Documented
    public double? Amount { get; set; }
    
    [JsonProperty("duration")]
    public double? Duration { get; set; }
    
    [JsonProperty("type")]// Documented
    public double? TypeCode { get; set; }
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

public class GismeteoResponseBodyHumidity
{
    [JsonProperty("percent")]// Documented
    public double? Percent { get; set; }
}

public class GismeteoResponseBodyWind
{
    [JsonProperty("direction")]
    public GismeteoResponseBodyWindDirection? Direction { get; set; }
    
    [JsonProperty("speed")]
    public GismeteoResponseBodyWindDirection? Speed { get; set; }
}

public class GismeteoResponseBodyWindDirection
{
    [JsonProperty("degree")]// Documented
    public double? Degree { get; set; }
    
    [JsonProperty("scale_8")]// Documented
    public double? CardinalDirectionCode { get; set; }
}

public class GismeteoResponseBodyWindSpeed
{
    [JsonProperty("km_h")]
    public double? KmH { get; set; }
    
    [JsonProperty("m_s")]// Documented
    public double? Ms { get; set; }
    
    [JsonProperty("mi_h")]
    public double? MiH { get; set; }
}

public class GismeteoResponseBodyCloudiness
{
    [JsonProperty("type")]// Documented
    public double? TypeCode { get; set; }
    
    [JsonProperty("percent")]// Documented
    public double? Percent { get; set; }
}

public class GismeteoResponseBodyDate
{
    [JsonProperty("UTC")]// Documented
    public DateTime? Utc { get; set; }
    
    [JsonProperty("time_zone_offset")]// Documented
    public double? TimeZoneOffset { get; set; }
    
    [JsonProperty("local")]// Documented
    public DateTime? Local { get; set; }
    
    //[JsonProperty("percent")] Not sure about the type
    //public double? Percent { get; set; }
    
    [JsonProperty("unix")]// Documented
    public double? Unix { get; set; }
}

public class GismeteoResponseBodyRadiation
{
    //[JsonProperty("uvb_index")] Not sure about the type
    //public double? UvbIndex { get; set; }
    
    [JsonProperty("UVB")]// Documented
    public double? Uvb { get; set; }
}

public class GismeteoResponseBodyTemperature
{
    [JsonProperty("comfort")]
    public GismeteoResponseBodyTemperatureComfort? Comfort { get; set; }
    
    [JsonProperty("water")]
    public GismeteoResponseBodyTemperatureWater? Water { get; set; }
    
    [JsonProperty("air")]
    public GismeteoResponseBodyTemperatureAir? Air { get; set; }
}

public class GismeteoResponseBodyTemperatureComfort
{ 
    [JsonProperty("C")]// Documented
    public double? DegreesCelcius { get; set; }
    
    [JsonProperty("F")]
    public double? DegreesFahrenheit { get; set; }
}

public class GismeteoResponseBodyTemperatureWater
{
    [JsonProperty("C")]// Documented
    public double? DegreesCelcius { get; set; }
    
    [JsonProperty("F")]
    public double? DegreesFahrenheit { get; set; }
}

public class GismeteoResponseBodyTemperatureAir
{
    [JsonProperty("C")]// Documented
    public double? DegreesCelcius { get; set; }
    
    [JsonProperty("F")]
    public double? DegreesFahrenheit { get; set; }
}

public class GismeteoResponseBodyDescription
{
    [JsonProperty("full")]// Documented
    public string? Full { get; set; }
}