using FormulaOneInfo;
using FormulaOneInfo.Infrastructure.ApiSportsAgent;
using FormulaOneInfo.Shared.Circuit;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

builder.Services.AddApiSportsAgent();

builder.Services.AddSingleton<CircuitStateContainer>();

await builder
    .Build()
    .RunAsync();
