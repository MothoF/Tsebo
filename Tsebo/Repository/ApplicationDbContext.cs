using Microsoft.EntityFrameworkCore;
using Tsebo.Entities;

namespace Tsebo.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        DbSet<Users> Users => Set<Users>();
        DbSet<Modules> Modules => Set<Modules>();
        DbSet<Topics> Topics => Set<Topics>();
        DbSet<Concepts> Concepts => Set<Concepts>();
        DbSet<UserTasks> UserTasks => Set<UserTasks>();
        DbSet<ModuleTopics> ModuleTopics => Set<ModuleTopics>();
    }
}
