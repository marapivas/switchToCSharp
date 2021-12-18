using Microsoft.EntityFrameworkCore;
using Workshop2.Models;

namespace Workshop2.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Assignee> Assignees { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignee>()
                .HasMany<Todo>(a => a.AssigneesTodo)
                .WithOne(a => a.Assignee)
                .HasForeignKey(a => a.AssigneeId)
                .IsRequired(true);
        }
    }
}
