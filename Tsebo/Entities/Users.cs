using System.Diagnostics.CodeAnalysis;

namespace Tsebo.Entities
{
    public class Users
    {
        public required String Username { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
    }
}
