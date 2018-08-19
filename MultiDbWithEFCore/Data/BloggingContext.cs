using BinZone.Sample.EF.MultiDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BinZone.Sample.EF.MultiDB.Data
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
          : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Blog>().HasData(new Blog { BlogId = 1, Url = "http://sample.com" });

            modelBuilder.Entity<Post>().HasData(
                new { BlogId = 1, PostId = 1, Title = "First post", Content = "Test 1" },
                new { BlogId = 1, PostId = 2, Title = "Second post", Content = "Test 2" });
        }
    }
}
