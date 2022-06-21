using MediatR;

namespace WebAssemblyWithAPI.Shared
{
    public class Bus : IBus
    {
        private readonly IMediator _mediator;
        public Bus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public virtual async Task<TResponse> Send<TResponse>(IRequest<TResponse> request)
        {
            TResponse response = await _mediator.Send(request);
            return response;
        }

        public virtual async Task<object?> Send(object request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        public void Publish<TNotification>(TNotification notification) where TNotification : INotification
        {
            _mediator.Publish(notification);
        }
    }
}