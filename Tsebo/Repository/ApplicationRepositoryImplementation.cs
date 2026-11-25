using Tsebo.Entities;

namespace Tsebo.Repository
{
    public class ApplicationRepositoryImplementation : IApplicationRepository
    {
        Task<UserTasks> IApplicationRepository.CreateUserTasksAsync(UserTasks userTask)
        {
            throw new NotImplementedException();
        }

        Task<bool> IApplicationRepository.DeleteUserTasksById(string username, string conceptCode)
        {
            throw new NotImplementedException();
        }

        Task<bool> IApplicationRepository.DeleteUserTasksByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        Task<UserTasks> IApplicationRepository.GetUserTaskByIdAsync(string username, string conceptCode)
        {
            throw new NotImplementedException();
        }

        Task<List<UserTasks>> IApplicationRepository.GetUserTasksByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        Task<bool> IApplicationRepository.UpdateUserTasksAsync(UserTasks userTask)
        {
            throw new NotImplementedException();
        }
    }
}
