namespace Tsebo.Entities
{
    public class Topics
    {
        public required String TopicCode { get; set; }
        public required String TopicName { get; set; }
        public required List<Concepts> Concepts { get; set; }
    }
}
