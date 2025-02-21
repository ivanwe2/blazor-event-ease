using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<IEventService, EventService>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<AttendanceService>();


builder.Services.AddScoped<UserSessionService>();
builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<UserSessionService>());
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
