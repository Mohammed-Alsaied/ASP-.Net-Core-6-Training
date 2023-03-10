using CarvedRock_BlazorWebAssembly;
using CarvedRock_BlazorWebAssembly.ApiServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7273") });
builder.Services.AddScoped<IProductApiService, ProductApiService>();

await builder.Build().RunAsync();
