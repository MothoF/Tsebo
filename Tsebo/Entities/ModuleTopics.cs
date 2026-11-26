namespace Tsebo.Entities
{
    public class ModuleTopics
    {
        public required string ModuleCode { get; set; }
        public Modules? Module { get; set; }
        public required string TopicCode { get; set; }
        public Topics? Topic { get; set; }

        public ModuleTopics(string ModuleCode, string TopicCode)
        {
            this.ModuleCode = ModuleCode;
            this.TopicCode = TopicCode;
        }
    }
}
