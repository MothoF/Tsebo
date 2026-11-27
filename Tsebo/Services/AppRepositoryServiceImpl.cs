using Tsebo.Entities;
using Tsebo.Repository;

namespace Tsebo.Services
{
    public class AppRepositoryServiceImpl : IApplicationRepositoryService
    {
        private readonly ApplicationDbContext dbContext;

        public AppRepositoryServiceImpl(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }
        async Task<UserTasks> IApplicationRepositoryService.CreateUserTasksAsync(UserTasks userTask)
        {
            var createdTask = dbContext.UserTasks.Add(userTask);
            await dbContext.SaveChangesAsync();
            return createdTask.Entity;
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
