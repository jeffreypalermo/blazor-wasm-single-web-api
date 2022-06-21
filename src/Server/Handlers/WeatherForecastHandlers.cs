using MediatR;
using WebAssemblyWithAPI.Shared.Models;
using WebAssemblyWithAPI.Shared.Queries;

namespace WebAssemblyWithAPI.Server.Handlers
{
    public class ForecastQueryHandler : IRequestHandler<ForecastQuery, WeatherForecast[]>
    {
        public Task<WeatherForecast[]> Handle(ForecastQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new WeatherForecastData().GetAll());
        }
    }
}
