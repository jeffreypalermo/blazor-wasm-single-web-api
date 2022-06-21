using MediatR;
using WebAssemblyWithAPI.Shared.Models;
using WebAssemblyWithAPI.Shared.Queries;

namespace WebAssemblyWithAPI.Server.Handlers;

public class UpdateForecastsCommandHandler : IRequestHandler<UpdateForecastCommand, WeatherForecast[]>
{
    public Task<WeatherForecast[]> Handle(UpdateForecastCommand request, CancellationToken cancellationToken)
    {
        for (int i = 0; i < request.Forecasts.Length; i++)
        {
            var forecast = request.Forecasts[i];
            if (forecast.Id == request.Id)
            {
                request.Forecasts[i].Summary = "Updated";
                return Task.FromResult(request.Forecasts);
            }
        }
        return Task.FromResult(request.Forecasts);
    }
}