using Blazored.LocalStorage;
using Dictionary.WebApp;
using Dictionary.WebApp.Infrastructure.Services.Abstractions;
using Dictionary.WebApp.Infrastructure.Services.Concretes;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddHttpClient("DictionaryWebApiClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7089");
});

builder.Services.AddScoped(sp =>
{
    var clientFactory = sp.GetRequiredService<IHttpClientFactory>();

    return clientFactory.CreateClient("DictionaryWebApiClient");

});

builder.Services.AddTransient<IEntryService, EntryService>();

builder.Services.AddTransient<IFavoriteService, FavoriteService>();

builder.Services.AddTransient<IIdentityService, IdentityService>();

builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<IVoteService, VoteService>();


//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
