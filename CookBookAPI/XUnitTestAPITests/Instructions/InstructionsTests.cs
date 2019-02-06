using CookBookAPI.Models;
using Xunit;

namespace XUnitTestAPITestss
{
    public class InstructionsTests
    {
        [Fact]
        public void CanGetRecipeID()
        {
            Instructions recipe = new Instructions();
            recipe.RecipeID = 6;

            Assert.Equal(6, recipe.RecipeID);
        }
        [Fact]
        public void CanSetRecipeID()
        {
            Instructions recipe = new Instructions();
            recipe.RecipeID = 6;
            recipe.RecipeID = 7;

            Assert.Equal(7, recipe.RecipeID);
        }
        [Fact]
        public void CanGetStepNumberID()
        {
            Instructions recipe = new Instructions();
            recipe.StepNumberID = 6;

            Assert.Equal(6, recipe.StepNumberID);
        }
        [Fact]
        public void CanSetStepNumberID()
        {
            Instructions recipe = new Instructions();
            recipe.StepNumberID = 5;
            recipe.StepNumberID = 15;

            Assert.Equal(15, recipe.StepNumberID);
        }
        [Fact]
        public void CanGetAction()
        {
            Instructions recipe = new Instructions();
            recipe.Action = "got jiggy with it";

            Assert.Equal("got jiggy with it", recipe.Action);
        }
        [Fact]
        public void CanSetAction()
        {
            Instructions recipe = new Instructions();
            recipe.Action = "pop";
            recipe.Action = "lock";

            Assert.Equal("lock", recipe.Action);
        }
    }
}
