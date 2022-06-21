using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace WebAssemblyWithAPI.Shared
{
    public class PublisherGateway : IPublisherGateway
    {
        private readonly HttpClient _httpClient;

        public PublisherGateway(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WebServiceMessage?> Publish(IRemoteableRequest request)
        {
            var message = new WebServiceMessage(request);
            return await SendToTopic(message);
        }

        public virtual async Task<WebServiceMessage?> SendToTopic(WebServiceMessage message)
        {
            HttpContent content = new StringContent(message.GetJson());
            var result = await _httpClient.PostAsJsonAsync("/api/WeatherForecast", message);
            var json = await result.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<WebServiceMessage>(json);
        }
    }
}