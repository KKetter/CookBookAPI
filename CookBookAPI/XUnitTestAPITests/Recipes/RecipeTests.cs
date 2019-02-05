using CookBookAPI.Models;
using Xunit;

namespace XUnitTestAPITests
{
    public class RecipeTests
    {
        [Fact]
        public void CanGetRecipefromAPI()
        {
            Recipes recipe = new Recipes();
            recipe.Name = "Pancakes";

            Assert.Equal("Pancakes", recipe.Name);
        }
    }
}
