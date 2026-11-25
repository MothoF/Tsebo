using Tsebo.Repository;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.AutoUpdateDatabase();
app.Run();
