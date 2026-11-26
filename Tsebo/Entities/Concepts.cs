namespace Tsebo.Entities
{
    public class Concepts
    {
        public required string ConceptCode { get; set; }
        public required string ConceptName { get; set; }
        public required string TopicCode { get; set; }
        public Topics? Topic { get; set; }
        public List<UserTasks>? UserTasks { get; set; }
        
        public Concepts(string ConceptCode, string ConceptName, string TopicCode)
        {
            this.ConceptCode = ConceptCode;
            this.ConceptName = ConceptName;
            this.TopicCode = TopicCode;
        }
    }
}
