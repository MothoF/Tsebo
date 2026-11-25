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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>()
                .HasKey(u => new { u.Username });

            modelBuilder.Entity<Modules>()
                .HasKey(m => new { m.ModuleCode });

            modelBuilder.Entity<Topics>()
                .HasKey(t => new { t.TopicCode });

            modelBuilder.Entity<Concepts>()
                .HasKey(c => new { c.ConceptCode });

            modelBuilder.Entity<UserTasks>()
                .HasKey(ut => new { ut.Username, ut.ConceptCode });

            modelBuilder.Entity<ModuleTopics>()
                .HasKey(mt => new { mt.ModuleCode, mt.TopicCode });
        }
    }
}
