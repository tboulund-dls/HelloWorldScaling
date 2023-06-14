using Microsoft.AspNetCore.Mvc;

namespace GreetingService.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        Console.WriteLine(Environment.MachineName);
        return "Hello";
    }
}