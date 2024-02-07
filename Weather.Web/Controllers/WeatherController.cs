using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Weather.Web.Models;

namespace Weather.Web.Controllers;

[Route("")]
[Route("weather")]
public class WeatherController : Controller
{
    public WeatherController(ILogger<WeatherController> logger)
    {
        _logger = logger;
    }

    [Route("")]
    [Route("general")]
    public IActionResult General(double latitude = 91, double longitude = 181)
    {
        return View();
    }
    
    [Route("detail")]
    public IActionResult Detail()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    private readonly ILogger<WeatherController> _logger;
}