using CookBookAPI.Models;
using Xunit;

namespace XUnitTestAPITests
{
    public class RecipeIngredientsTests
    {
        [Fact]
        public void CanGetRecipeID()
        {
            RecipeIngredients recipe = new RecipeIngredients();
            recipe.RecipeID = 4;

            Assert.Equal(4, recipe.RecipeID);
        }
        [Fact]
        public void CanSetRecipeID()
        {
            RecipeIngredients recipe = new RecipeIngredients();
            recipe.RecipeID = 4;
            recipe.RecipeID = 14;

            Assert.Equal(14, recipe.RecipeID);
        }
        [Fact]
        public void CanGetIngredientsID()
        {
            RecipeIngredients recipe = new RecipeIngredients();
            recipe.IngredientsID = 44;

            Assert.Equal(44, recipe.IngredientsID);
        }
        [Fact]
        public void CanSetIngredientsID()
        {
            RecipeIngredients recipe = new RecipeIngredients();
            recipe.IngredientsID = 4;
            recipe.IngredientsID = 14;

            Assert.Equal(14, recipe.IngredientsID);
        }
        [Fact]
        public void CanGetQuantity()
        {
            RecipeIngredients recipe = new RecipeIngredients();
            recipe.Quantity = "1/2 cup";

            Assert.Equal("1/2 cup", recipe.Quantity);
        }
        [Fact]
        public void CanSetQuantity()
        {
            RecipeIngredients recipe = new RecipeIngredients();
            recipe.Quantity = "1 oz";
            recipe.Quantity = "5 lbs";

            Assert.Equal("5 lbs", recipe.Quantity);
        }

    }
}
