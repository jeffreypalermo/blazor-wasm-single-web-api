using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebAssemblyWithAPI.Client;
using WebAssemblyWithAPI.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddTransient<PublisherGateway>();
builder.Services.AddTransient<IBus, RemoteableBus>();
var url = builder.Configuration.GetValue<string>("RemoteBusUrl");
builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(url) });

await builder.Build().RunAsync();
