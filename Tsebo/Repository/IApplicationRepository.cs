using Tsebo.Entities;

namespace Tsebo.Repository
{
    public interface IApplicationRepository
    {
        public Task<UserTasks> GetUserTaskByIdAsync(string username, string conceptCode);

        public Task<List<UserTasks>> GetUserTasksByUsernameAsync(string username);

        public Task<bool> UpdateUserTasksAsync(UserTasks userTask);

        public Task<UserTasks> CreateUserTasksAsync(UserTasks userTask);

        public Task<bool> DeleteUserTasksByUsernameAsync(string username);

        public Task<bool> DeleteUserTasksById(string username, string conceptCode);
    }
}
