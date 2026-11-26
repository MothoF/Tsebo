using System.Diagnostics.CodeAnalysis;

namespace Tsebo.Entities
{
    public class Users
    {
        public required string Username { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public List<UserTasks>? UserTasks { get; set; }
        [SetsRequiredMembers]
        public Users(string Username, string FirstName, string LastName, List<UserTasks>? UserTasks)
        {
            this.Username = Username;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserTasks = UserTasks;
        }

        public Users() { }
    }
}
