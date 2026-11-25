using Tsebo.Entities;

namespace Tsebo.Services
{
    public class AppRepositoryServiceImpl : IApplicationRepositoryService
    {
        Task<UserTasks> IApplicationRepositoryService.CreateUserTasksAsync(UserTasks userTask)
        {
            throw new NotImplementedException();
        }

        Task<bool> IApplicationRepositoryService.DeleteUserTasksById(string username, string conceptCode)
        {
            throw new NotImplementedException();
        }

        Task<bool> IApplicationRepositoryService.DeleteUserTasksByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        Task<UserTasks> IApplicationRepositoryService.GetUserTaskByIdAsync(string username, string conceptCode)
        {
            throw new NotImplementedException();
        }

        Task<List<UserTasks>> IApplicationRepositoryService.GetUserTasksByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        Task<bool> IApplicationRepositoryService.UpdateUserTasksAsync(UserTasks userTask)
        {
            throw new NotImplementedException();
        }
    }
}
