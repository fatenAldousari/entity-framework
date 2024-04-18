using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class BlogContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Name = "Food Blog",
                    Url = "https://www.myfood.eat"
                }
            );
        }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlite("Data Source=asp.dp");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
