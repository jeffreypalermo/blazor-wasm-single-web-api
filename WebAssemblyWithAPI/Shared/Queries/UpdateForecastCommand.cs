using MediatR;
using WebAssemblyWithAPI.Shared.Models;

namespace WebAssemblyWithAPI.Shared.Queries
{
    public record UpdateForecastCommand(int Id, WeatherForecast[] Forecasts) : IRequest<WeatherForecast[]>,
        IRemoteableRequest;
}
