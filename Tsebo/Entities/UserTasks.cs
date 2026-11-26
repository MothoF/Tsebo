using System.Diagnostics.CodeAnalysis;

namespace Tsebo.Entities
{
    public class UserTasks
    {
        public required String Username { get; set; }
        public Users? User { get; set; }
        public required String ConceptCode { get; set; }
        public Concepts? Concept { get; set; }
        public DateOnly? Deadline { get; set; }
        public String? Status { get; set; }
        public String? Priority { get; set; }
        [SetsRequiredMembers]
        public UserTasks(string username, Users? user, string conceptCode, Concepts? concept, DateOnly? deadline, string? status, string? priority)
        {
            Username = username;
            User = user;
            ConceptCode = conceptCode;
            Concept = concept;
            Deadline = deadline;
            Status = status;
            Priority = priority;
        }

        public UserTasks() { }
    }
}
