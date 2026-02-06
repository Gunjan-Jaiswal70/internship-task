using BlogApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApiProject.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
