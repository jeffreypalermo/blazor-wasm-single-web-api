using MediatR;
using WebAssemblyWithAPI.Shared.Models;

namespace WebAssemblyWithAPI.Shared.Queries
{
    public record AdditionalForecastQuery(int Id) : IRequest<AdditionalForecastData>, IRemoteableRequest;
}