using Microsoft.AspNetCore.Mvc;
using WebAssemblyWithAPI.Shared;

namespace WebAssemblyWithAPI.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IBus _bus;

    public WeatherForecastController(IBus bus)
    {
        _bus = bus;
    }

    [HttpPost]
    public async Task<string> Post(WebServiceMessage webServiceMessage)
    {
        var result = await _bus.Send(webServiceMessage.GetBodyObject()) ?? throw new InvalidOperationException();
        return new WebServiceMessage(result).GetJson();
    }
}