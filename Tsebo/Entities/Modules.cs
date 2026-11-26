namespace Tsebo.Entities
{
    public class Modules
    {
        public required string ModuleCode { get; set; }
        public required string ModuleName { get; set; }
        public List<ModuleTopics>? ModuleTopics { get; set; }

        public Modules(string ModuleCode, string ModuleName, List<ModuleTopics>? ModuleTopics)
        {
            this.ModuleCode = ModuleCode;
            this.ModuleName = ModuleName;
            this.ModuleTopics = ModuleTopics;
        }
    }
}
