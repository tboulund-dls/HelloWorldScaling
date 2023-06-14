using Microsoft.AspNetCore.Mvc;

namespace PlanetService.Controllers;

[ApiController]
[Route("[controller]")]
public class PlanetController : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        Console.WriteLine(Environment.MachineName);
        return "World";
    }
}