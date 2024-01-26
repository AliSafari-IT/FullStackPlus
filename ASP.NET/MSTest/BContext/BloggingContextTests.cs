using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.BContext;
using Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MSTest.BContext;

[TestClass]
public class BloggingContextTests
{
    private BloggingContext CreateDbContext()
    {
        var options = new DbContextOptionsBuilder<BloggingContext>()
            .UseSqlServer("DefaultConnection")
            .Options;

        return new BloggingContext(options);
    }

    [TestMethod]
    public void BloggingContext_CanBeInstantiated()
    {
        var context = CreateDbContext();
        Assert.IsNotNull(context, "BloggingContext should be successfully instantiated.");
    }

    [TestMethod]
    public void UsersDbSet_IsInitialized()
    {
        var context = CreateDbContext();
        Assert.IsNotNull(context.Users, "Users DbSet should be initialized.");
    }

    // Similar tests for Posts, Comments, Categories, Tags, and PostTags
    [TestMethod]
    public void PostsDbSet_IsInitialized()
    {
        var context = CreateDbContext();
        Assert.IsNotNull(context.Posts, "Posts DbSet should be initialized.");
    }

    // Add similar tests for Comments, Categories, Tags, and PostTags
}
