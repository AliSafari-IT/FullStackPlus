using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void PropertyAssignmentTest()
        {
            // Arrange
            var category = new Category
            {
                CategoryId = 1,
                Name = "Tech"
            };

            // Assert
            Assert.AreEqual(1, category.CategoryId, "CategoryId should be correctly assigned.");
            Assert.AreEqual("Tech", category.Name, "Name should be correctly assigned.");
        }

        [TestMethod]
        public void PostsCollectionInitializationTest()
        {
            // Arrange
            var category = new Category();

            // Assert
            Assert.IsNotNull(category.Posts, "Posts collection should be initialized.");
        }

        [TestMethod]
        public void AddingPostToCategoryIncreasesCount()
        {
            // Arrange
            var category = new Category();
            var post = new Post { PostId = 1, Title = "Test Post" };

            // Act
            category.Posts = new List<Post>
            {
                post
            }; 

            // Assert
            Assert.AreEqual(1, category.Posts.Count, "Adding a post should increase the count.");
        }
    }
}
