namespace Tsebo.Tests;

using Tsebo.Services;
using Tsebo.Entities;

public class AppRepoTests
{
    private readonly IApplicationRepositoryService repositoryService;

    public AppRepoTests(IApplicationRepositoryService repositoryService)
    {
        this.repositoryService = repositoryService;
    }

    [Fact]
    public async Task AddUserTask_ValidUserTask_Succeed()
    {
        Users user = new Users("johndoe@testing.com", "John", "Doe", null);
        Topics topic = new Topics("06", "Collections", null, null);
        Concepts concept = new Concepts("ARS", "Arrays", "06", null, null);
        UserTasks task = new UserTasks("johndoe@testing.com", user, "ARS", concept, new DateOnly(2026, 12, 15), "InProgress","Medium");

        UserTasks createdTask = (UserTasks) await repositoryService.CreateUserTasksAsync(task);

        Assert.NotNull(createdTask);
    }
}
