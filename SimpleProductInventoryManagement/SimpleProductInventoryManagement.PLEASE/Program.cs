using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SimpleProductInventoryManagement.BlazorUI.Providers;
using SimpleProductInventoryManagement.BlazorUI.Services;
using SimpleProductInventoryManagement.Contracts;
using SimpleProductInventoryManagement.BlazorUI;
using SimpleProductInventoryManagement.BlazorUI.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();

builder.Services.AddTransient<JwtAuthorizationMessageHandler>();

builder.Services.AddHttpClient("PublicAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:7263/");
});

builder.Services.AddHttpClient("AuthorizedAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:7263/");
})
.AddHttpMessageHandler<JwtAuthorizationMessageHandler>();


builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

builder.Services.AddScoped<IProductEntityService, ProductEntityService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();



await builder.Build().RunAsync();
