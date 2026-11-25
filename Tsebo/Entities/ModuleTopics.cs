namespace Tsebo.Entities
{
    public class ModuleTopics
    {
        public required String ModuleCode { get; set; }
        public required Modules Module { get; set; }
        public required String TopicCode { get; set; }
        public required Topics Topic { get; set; }
    }
}
