using MediatR;

namespace WebAssemblyWithAPI.Shared.Queries;

public record ServerInfoQuery : IRequest<ServerInfo>, IRemoteableRequest;
public record ServerInfo(string OperatingSystem, string Version, string MachineName);