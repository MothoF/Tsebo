namespace Tsebo.Entities
{
    public class Topics
    {
        public required String TopicCode { get; set; }
        public String? TopicName { get; set; }
        public List<Concepts> Concepts { get; set; }
    }
}
