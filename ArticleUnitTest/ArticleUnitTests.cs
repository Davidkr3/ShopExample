using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopExample.Model;

namespace ShopExample.ArticleUnitTest
{
    [TestClass]
    public class ArticleUnitTests
    {
        [TestMethod]
        public void GivenAUserWhenAddsArticleThenTheArticleIsAdded()
        {
            // Arrange
            var article = new Article();
            article.Price = 95.5;
            article.Name = "whatever";
            PriceManager priceManager = new PriceManager();

            // Act
            priceManager.AddArticle(article);

            // Assert
            Assert.IsTrue(priceManager.Articles.Count == 1, "The article has not been properly added");

        }

    }
}
