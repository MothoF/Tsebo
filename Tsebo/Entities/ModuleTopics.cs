using System.Diagnostics.CodeAnalysis;

namespace Tsebo.Entities
{
    public class ModuleTopics
    {
        public required string ModuleCode { get; set; }
        public Modules? Module { get; set; }
        public required string TopicCode { get; set; }
        public Topics? Topic { get; set; }
        [SetsRequiredMembers]
        public ModuleTopics(string ModuleCode, string TopicCode, Modules? Module, Topics? Topic)
        {
            this.ModuleCode = ModuleCode;
            this.TopicCode = TopicCode;
            this.Module = Module;
            this.Topic = Topic;
        }

        public ModuleTopics() { }
    }
}
