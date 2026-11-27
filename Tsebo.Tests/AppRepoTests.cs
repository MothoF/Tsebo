namespace Tsebo.Tests;

using Tsebo.Services;
using Tsebo.Entities;
using Microsoft.EntityFrameworkCore;
using Tsebo.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

public class AppRepoTests : IClassFixture<CustomWebApplicationFactory>, IAsyncLifetime
{
    private readonly IApplicationRepositoryService repositoryService;
    private readonly CustomWebApplicationFactory factory;
    private ApplicationDbContext dbContext;

    public AppRepoTests(CustomWebApplicationFactory factory)
    {
        this.factory = factory;
        var scope = factory.Services.CreateScope();
        this.repositoryService = scope.ServiceProvider.GetRequiredService<IApplicationRepositoryService>();
        this.dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    }

    [Fact]
    public async Task AddUserTask_ValidUserTask_Succeed()
    {
        UserTasks task = new UserTasks("johndoe@testing.com", null, "ARS", null, new DateOnly(2026, 12, 15), "InProgress","Medium");

        UserTasks createdTask = (UserTasks) await repositoryService.CreateUserTasksAsync(task);

        Assert.NotNull(createdTask);
    }

    public async Task DisposeAsync()
    {
        var user = dbContext.Users.Find("johndoe@testing.com");
        var topic = dbContext.Topics.Find("06");
        var concept = dbContext.Concepts.Find("ARS");

        dbContext.Users.Remove(user);
        dbContext.Topics.Remove(topic);
        dbContext.Concepts.Remove(concept);
        await dbContext.SaveChangesAsync();
        dbContext.Dispose();
    }

    public async Task InitializeAsync()
    {
        Users user = new Users("johndoe@testing.com", "John", "Doe", null);
        Topics topic = new Topics("06", "Collections", null, null);
        Concepts concept = new Concepts("ARS", "Arrays", "06", null, null);

        dbContext.Users.Add(user);
        dbContext.Topics.Add(topic);
        dbContext.Concepts.Add(concept);
        await dbContext.SaveChangesAsync();
    }
}
