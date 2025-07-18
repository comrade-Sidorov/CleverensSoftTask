using Server.Domain;
using Server.Service;

var count = new Count();
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IServerService, ServerService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/add", (IServerService _serverService) =>
{
    _serverService.AddCounter(count.Counter);
});

app.MapGet("/remove", (IServerService _serverService) =>
{
    _serverService.RemoveCounter(count.Counter);
});

app.Run();
