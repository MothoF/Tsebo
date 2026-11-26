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
    public async void AddUserTask_ValidUserTask_Succeed()
    {
        Users user = new Users("johndoe@testing.com", "John", "Doe");
        Topics topic = new Topics("06", "Collections");
        Concepts concept = new Concepts("ARS", "Arrays", "06");
        UserTasks task = new UserTasks("johndoe@testing.com", "ARS", "InProgress","Medium","2026-12-15");

        UserTasks createdTask = (UserTasks) await repositoryService.CreateUserTasksAsync(task);

        Assert.NotNull(createdTask);
    }
}
