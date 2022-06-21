using MediatR;
using WebAssemblyWithAPI.Shared.Queries;

namespace WebAssemblyWithAPI.Server.Handlers;

public class ServerInfoQueryHandler : IRequestHandler<ServerInfoQuery, ServerInfo>
{
    public Task<ServerInfo> Handle(ServerInfoQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(
            new ServerInfo(Environment.OSVersion.Platform.ToString(), Environment.OSVersion.VersionString,
                Environment.MachineName));
    }
}