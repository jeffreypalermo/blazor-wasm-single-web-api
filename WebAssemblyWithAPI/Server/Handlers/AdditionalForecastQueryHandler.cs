using MediatR;
using WebAssemblyWithAPI.Shared.Models;
using WebAssemblyWithAPI.Shared.Queries;

namespace WebAssemblyWithAPI.Server.Handlers;

public class AdditionalForecastQueryHandler : IRequestHandler<AdditionalForecastQuery, AdditionalForecastData>
{
    public Task<AdditionalForecastData> Handle(AdditionalForecastQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new AdditionalForecastData("This is additonal data for forcast (" + request.Id + ")"));
    }
}