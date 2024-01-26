using Models;

namespace MSTest
{
    [TestClass]
    public class PostUnitTests
    {
        [TestMethod]
        public void PostPropertyTest()
        {
            // Arrange
            var post = new Post
            {
                PostId = 1,
                Title = "Test Title",
                Content = "Test Content",
                DateCreated = DateTime.Now,
                UserId = 123
            };

            // Act
            // (In this case, act is not necessary as we are just assigning values)

            // Assert
            Assert.AreEqual(1, post.PostId, "PostId should be correctly assigned.");
            Assert.AreEqual("Test Title", post.Title, "Title should be correctly assigned.");
            Assert.AreEqual("Test Content", post.Content, "Content should be correctly assigned.");
            Assert.IsNotNull(post.DateCreated, "DateCreated should be assigned.");
            Assert.AreEqual(123, post.UserId, "UserId should be correctly assigned.");
        }

        [TestMethod]
        public void PostCommentsCollectionTest()
        {
            // Arrange
            var post = new Post();

            // Act
            // No action is necessary as we are testing the initial state

            // Assert
            Assert.IsNotNull(post.Comments, "Comments collection should be initialized.");
            Assert.AreEqual(0, post.Comments.Count, "Comments collection should be empty on initialization.");
        }
        [TestMethod]
        public void AddingCommentToPostIncreasesCount()
        {
            // Arrange
            var post = new Post();
            var comment = new Comment { CommentId = 1, DateCreated = DateTime.Now };

            // Act
            post.Comments.Add(comment);

            // Assert
            Assert.AreEqual(1, post.Comments.Count, "Adding a comment should increase the count.");
        }


        // Additional tests can be added here
    }
}