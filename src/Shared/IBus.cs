using MediatR;

namespace WebAssemblyWithAPI.Shared;

public interface IBus
{
    Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
    Task<object?> Send(object request);
    void Publish<TNotification>(TNotification notification) where TNotification : INotification;
}