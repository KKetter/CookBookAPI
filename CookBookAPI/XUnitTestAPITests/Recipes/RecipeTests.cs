using CookBookAPI.Models;
using Xunit;

namespace XUnitTestAPITests
{
    public class RecipeTests
    {
        [Fact]
        public void CanGetRecipeName()
        {
            Recipes recipe = new Recipes();
            recipe.Name = "Pancakes";

            Assert.Equal("Pancakes", recipe.Name);
        }
        [Fact]
        public void CanSetRecipeName()
        {
            Recipes recipe = new Recipes();
            recipe.Name = "Pancakes";
            recipe.Name = "Waffles";


            Assert.Equal("Waffles", recipe.Name);
        }
        [Fact]
        public void CanGetRecipeID()
        {
            Recipes recipe = new Recipes();
            recipe.ID = 4;

            Assert.Equal(4, recipe.ID);
        }
        [Fact]
        public void CanSetRecipeID()
        {
            Recipes recipe = new Recipes();
            recipe.ID = 4;
            recipe.ID = 5;

            Assert.Equal(5, recipe.ID);
        }
    }
}
