using Microsoft.EntityFrameworkCore;
using QuizApplication.Models;

namespace QuizApplication.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
    
}
