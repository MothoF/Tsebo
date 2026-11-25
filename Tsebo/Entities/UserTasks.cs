namespace Tsebo.Entities
{
    public class UserTasks
    {
        public required String Username { get; set; }
        public required Users User { get; set; }
        public required String ConceptCode { get; set; }
        public required Concepts Concept { get; set; }
        public DateOnly? Deadline { get; set; }
        public String? Status { get; set; }
        public String? Priority { get; set; }
    }
}
