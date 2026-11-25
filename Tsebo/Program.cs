using Tsebo.Repository;
using Tsebo.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("TseboPrimaryDb");
builder.Services.AddNpgsql<ApplicationDbContext>(connectionString);
builder.Services.AddScoped<IApplicationRepositoryService, AppRepositoryServiceImpl>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.AutoUpdateDatabase();
app.Run();
