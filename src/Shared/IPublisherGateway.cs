namespace WebAssemblyWithAPI.Shared
{
    public interface IPublisherGateway
    {
        Task<WebServiceMessage?> Publish(IRemoteableRequest request);
    }
}
