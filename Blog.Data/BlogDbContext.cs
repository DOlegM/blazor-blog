using Blog.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Blog.Data;

public class BlogDbContext : DbContext
{
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    { }

}

public class BlogDbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
{
    public BlogDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BlogDbContext>();
        optionsBuilder.UseNpgsql("User ID=postgres;Password=password;Server=localhost;Port=5432;Database=BlogDb;");
        return new BlogDbContext(optionsBuilder.Options);
    }
}

// TODO: Continue from Creating an Interface