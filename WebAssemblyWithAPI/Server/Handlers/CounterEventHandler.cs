using System.Diagnostics;
using MediatR;
using WebAssemblyWithAPI.Shared.Queries;

namespace WebAssemblyWithAPI.Server.Handlers
{
    public class CounterQueryHandler : IRequestHandler<CounterQuery, ServerCount>
    {
        public Task<ServerCount> Handle(CounterQuery request, CancellationToken cancellationToken)
        {
            var serverProcessName = Process.GetCurrentProcess().ProcessName;
            var serverCount = new ServerCount(request.Count + 2, serverProcessName);
            return Task.FromResult(serverCount);
        }
    }
}
