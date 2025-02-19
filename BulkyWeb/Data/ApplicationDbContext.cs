using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Web Development", DisplayOrder = 1 },
                new Category { ID = 2, Name = "Programming Languages", DisplayOrder = 2 },
                new Category { ID = 3, Name = "Databases", DisplayOrder = 3 }
            );
        }
    }
}
