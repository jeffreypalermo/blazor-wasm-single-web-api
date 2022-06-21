using MediatR;
using WebAssemblyWithAPI.Shared.Models;

namespace WebAssemblyWithAPI.Shared.Queries
{
    public class ForecastQuery : IRequest<WeatherForecast[]>, IRemoteableRequest
    {
    }
}