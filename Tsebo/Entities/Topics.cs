namespace Tsebo.Entities
{
    public class Topics
    {
        public required string TopicCode { get; set; }
        public required string TopicName { get; set; }
        public List<Concepts>? Concepts { get; set; }
        public List<ModuleTopics>? ModuleTopics { get; set; }

        public Topics(string topicCode, string topicName, List<Concepts>? concepts, List<ModuleTopics>? moduleTopics)
        {
            TopicCode = topicCode;
            TopicName = topicName;
            Concepts = concepts;
            ModuleTopics = moduleTopics;
        }
    }
}
