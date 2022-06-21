using MediatR;

namespace WebAssemblyWithAPI.Shared.Queries
{
    public record CounterQuery(int Count) : IRequest<ServerCount>, IRemoteableRequest;

    public record ServerCount(int NewCount, string? ServerProcessName);
}