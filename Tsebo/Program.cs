using Tsebo.Repository;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("TseboPrimaryDb");
builder.Services.AddNpgsql<ApplicationDbContext>(connectionString);
builder.Services.AddScoped<IApplicationRepository, ApplicationRepositoryImplementation>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.AutoUpdateDatabase();
app.Run();
