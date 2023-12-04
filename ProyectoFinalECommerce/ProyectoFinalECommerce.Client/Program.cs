using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProyectoFinalECommerce.Client;
using ProyectoFinalECommerce.Client.Services.ServicioCategoria;
using ProyectoFinalECommerce.Client.Services.ServicioProducto;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IServicioProducto, ServicioProducto>();
builder.Services.AddScoped<IServicioCategoria, ServicioCategoria>();

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

await builder.Build().RunAsync();
