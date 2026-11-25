namespace Tsebo.Entities
{
    public class Concepts
    {
        public required String ConceptCode { get; set; }
        public required String ConceptName { get; set; }
        public String? TopicCode { get; set; }
        public Topics? Topic { get; set; }
        public required List<UserTasks> UserTasks { get; set; }
    }
}
