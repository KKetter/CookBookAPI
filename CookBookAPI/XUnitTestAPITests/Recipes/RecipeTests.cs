using CookBookAPI.Controllers;
using CookBookAPI.Data;
using CookBookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace XUnitTestAPITests
{
    public class RecipeTests
    {
        private readonly IConfiguration configuration;

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
        [Fact]
        public async void CanDeleteRecipe()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanDeleteRecipe").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Recipes recipe = new Recipes();
                recipe.ID = 1;
                recipe.Name = "Sketti n Ketchup";
                Recipes recipe2 = new Recipes();
                recipe2.ID = 2;
                recipe2.Name = "Bread n Water";

                //Act
                RecipesController recipesController = new RecipesController(context, configuration);
                await recipesController.Post(recipe);
                await recipesController.Post(recipe2);
                await recipesController.Delete(recipe.ID);
                var result = context.Recipes.FirstOrDefault(c => c.ID == recipe.ID);

                //Assert
                Assert.Null(result);
            }
        }
        [Fact]
        public async void CanCreateRecipe()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanDeleteRecipe").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Recipes recipe = new Recipes();
                recipe.ID = 1;
                recipe.Name = "Sketti n Ketchup";
                

                //Act
                RecipesController recipesController = new RecipesController(context, configuration);
                await recipesController.Post(recipe);
                var result = context.Recipes.FirstOrDefault(c => c.ID == recipe.ID);

                //Assert
                Assert.Equal(recipe, result);
            }
        }
        [Fact]
        public async void CanEditRecipeToAction()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanEditRecipeToAction").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Recipes recipe = new Recipes();
                recipe.ID = 1;
                recipe.Name = "Sketti n Ketchup";
                Recipes recipe2 = new Recipes();
                recipe2.ID = 2;
                recipe2.Name = "Bread n Water";
                Recipes recipe3 = new Recipes();
                recipe3.ID = 3;
                recipe3.Name = "Knuckle Sandwich";

                //Act
                RecipesController recipesController = new RecipesController(context, configuration);
                await recipesController.Post(recipe);
                await recipesController.Post(recipe2);
                var data = await recipesController.Put(3, recipe3);

                //Assert
                Assert.IsType<RedirectToActionResult>(data);
            }
        }
        [Fact]
        public async void CanEditRecipeBadRequest()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanEditRecipeBadRequest").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Recipes recipe = new Recipes();
                recipe.ID = 1;
                recipe.Name = "Sketti n Ketchup";
                Recipes recipe2 = new Recipes();
                recipe2.ID = 2;
                recipe2.Name = "Bread n Water";
                Recipes recipe3 = new Recipes();
                recipe3.ID = 3;
                recipe3.Name = "Knuckle Sandwich";

                //Act
                RecipesController recipesController = new RecipesController(context, configuration);
                await recipesController.Post(recipe);
                await recipesController.Post(recipe2);
                var data = await recipesController.Put(6, recipe3);

                //Assert
                Assert.IsType<BadRequestObjectResult>(data);
            }
        }
        [Fact]
        public async void CanEditRecipeOk()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanEditRecipeOk").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Recipes recipe = new Recipes();
                recipe.ID = 1;
                recipe.Name = "Sketti n Ketchup";
                Recipes recipe2 = new Recipes();
                recipe2.ID = 2;
                recipe2.Name = "Bread n Water";
                Recipes recipe3 = new Recipes();
                recipe3.ID = 3;
                recipe3.Name = "Knuckle Sandwich";

                //Act
                RecipesController recipesController = new RecipesController(context, configuration);
                await recipesController.Post(recipe);
                await recipesController.Post(recipe2);
                var data = await recipesController.Put(2, recipe2);

                //Assert
                Assert.IsType<OkObjectResult>(data);
            }
        }
        [Fact]
        public async void CanGetOneRecipeNotFound()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGettRecipeOk").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Recipes recipe = new Recipes();
                recipe.ID = 1;
                recipe.Name = "Sketti n Ketchup";
                Recipes recipe2 = new Recipes();
                recipe2.ID = 2;
                recipe2.Name = "Bread n Water";
                Recipes recipe3 = new Recipes();
                recipe3.ID = 3;
                recipe3.Name = "Knuckle Sandwich";

                //Act
                RecipesController recipesController = new RecipesController(context, configuration);
                await recipesController.Post(recipe);
                await recipesController.Post(recipe2);
                var data = recipesController.Get(6);

                //Assert
                Assert.IsType<NotFoundResult>(data);
            }
        }
        [Fact]
        public async void CanGetOneRecipeOkResult()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGetOneRecipeOkResult").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Recipes recipe = new Recipes();
                recipe.ID = 1;
                recipe.Name = "Sketti n Ketchup";
                Recipes recipe2 = new Recipes();
                recipe2.ID = 2;
                recipe2.Name = "Bread n Water";
                Recipes recipe3 = new Recipes();
                recipe3.ID = 3;
                recipe3.Name = "Knuckle Sandwich";

                //Act
                RecipesController recipesController = new RecipesController(context, configuration);
                await recipesController.Post(recipe);
                await recipesController.Post(recipe2);
                await recipesController.Post(recipe3);
                var data = recipesController.Get(3);

                //Assert
                Assert.IsType<OkObjectResult>(data);
            }
        }
        [Fact]
        public async void CanGetCollectionOfRecipes()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGetCollectionOfRecipes").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Recipes recipe = new Recipes();
                recipe.ID = 1;
                recipe.Name = "Sketti n Ketchup";
                Recipes recipe2 = new Recipes();
                recipe2.ID = 2;
                recipe2.Name = "Bread n Water";
                Recipes recipe3 = new Recipes();
                recipe3.ID = 3;
                recipe3.Name = "Knuckle Sandwich";

                //Act
                RecipesController recipesController = new RecipesController(context, configuration);
                await recipesController.Post(recipe);
                await recipesController.Post(recipe2);
                await recipesController.Post(recipe3);
                var data = recipesController.Get().ToList();

                //Assert
                Assert.Equal(3, data.Count);
            }
        }
    }
}
