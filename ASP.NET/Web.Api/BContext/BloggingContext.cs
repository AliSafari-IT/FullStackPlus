using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;

namespace Web.Api.BContext
{
    public class BloggingContext(DbContextOptions<BloggingContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<WeatherForecast> Forecast { get; set; }
    }
}