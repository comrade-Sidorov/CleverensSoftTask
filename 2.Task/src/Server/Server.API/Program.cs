using Server.Domain;
using Server.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<Count>();
builder.Services.AddSingleton<IServerService, ServerService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/add", (IServerService serverService, Count count) =>
{
    serverService.AddCounter(count);
    return count.Counter;
});

app.MapGet("/remove", (IServerService serverService,  Count count) =>
{
    serverService.RemoveCounter(count);
    return count.Counter;
});

app.Run();
