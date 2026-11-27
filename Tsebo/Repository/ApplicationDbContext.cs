using Microsoft.EntityFrameworkCore;
using Tsebo.Entities;

namespace Tsebo.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users => Set<Users>();
        public DbSet<Modules> Modules => Set<Modules>();
        public DbSet<Topics> Topics => Set<Topics>();
        public DbSet<Concepts> Concepts => Set<Concepts>();
        public DbSet<UserTasks> UserTasks => Set<UserTasks>();
        public DbSet<ModuleTopics> ModuleTopics => Set<ModuleTopics>();

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


            modelBuilder.Entity<UserTasks>()
                .HasOne(ut => ut.User)
                .WithMany(u => u.UserTasks)
                .HasForeignKey(ut => ut.Username);

            modelBuilder.Entity<UserTasks>()
                .HasOne(ut => ut.Concept)
                .WithMany(c => c.UserTasks)
                .HasForeignKey(ut => ut.ConceptCode);

            modelBuilder.Entity<Concepts>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Concepts)
                .HasForeignKey(c => c.TopicCode);
            
            modelBuilder.Entity<ModuleTopics>()
                .HasOne(mt => mt.Module)
                .WithMany(m => m.ModuleTopics)
                .HasForeignKey(mt => mt.ModuleCode);

            modelBuilder.Entity<ModuleTopics>()
                .HasOne(mt => mt.Topic)
                .WithMany(t => t.ModuleTopics)
                .HasForeignKey(mt => mt.TopicCode);
        }
    }
}
