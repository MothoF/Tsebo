namespace Tsebo.Entities
{
    public class Modules
    {
        public required String ModuleCode { get; set; }
        public required String ModuleName { get; set; }
        public required List<ModuleTopics> ModuleTopics { get; set; }
    }
}
