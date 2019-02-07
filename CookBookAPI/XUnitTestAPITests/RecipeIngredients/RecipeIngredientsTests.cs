using CookBookAPI.Controllers;
using CookBookAPI.Data;
using CookBookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Xunit;

namespace XUnitTestAPITests
{
    public class RecipeIngredientsTests
    {
        private readonly IConfiguration configuration;

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
        [Fact]
        public async void CannotCreateRecipeIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CannotCreateRecipeIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                RecipeIngredients recipeIng = new RecipeIngredients();
                recipeIng.RecipeID = 1;
                recipeIng.IngredientsID = 1;
                recipeIng.Quantity = "1 pound";
                RecipeIngredients recipeIng2 = new RecipeIngredients();
                recipeIng2.RecipeID = 1;
                recipeIng2.IngredientsID = 2;
                recipeIng2.Quantity = "1 cup";

                //Act
                RecipeIngredientsController recipeIngredientsController = new RecipeIngredientsController(context, configuration);
                await recipeIngredientsController.Post(recipeIng);
                await recipeIngredientsController.Post(recipeIng2);
                var result = await recipeIngredientsController.Delete(4, 4);

                //Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
        [Fact]
        public async void CanCreateRecipeIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanCreateRecipeIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                RecipeIngredients recipeIng = new RecipeIngredients();
                recipeIng.RecipeID = 1;
                recipeIng.IngredientsID = 1;
                recipeIng.Quantity = "1 pound";
                RecipeIngredients recipeIng2 = new RecipeIngredients();
                recipeIng2.RecipeID = 1;
                recipeIng2.IngredientsID = 2;
                recipeIng2.Quantity = "1 cup";

                //Act
                RecipeIngredientsController recipeIngredientsController = new RecipeIngredientsController(context, configuration);
                await recipeIngredientsController.Post(recipeIng);
                await recipeIngredientsController.Post(recipeIng2);
                var result = await recipeIngredientsController.Delete(1, 2);

                //Assert
                Assert.IsType<OkObjectResult>(result);
            }
        }
        [Fact]
        public async void EditMakesNewRecipeIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("EditMakesNewRecipeIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                RecipeIngredients recipeIng = new RecipeIngredients();
                recipeIng.RecipeID = 1;
                recipeIng.IngredientsID = 1;
                recipeIng.Quantity = "1 pound";
                RecipeIngredients recipeIng2 = new RecipeIngredients();
                recipeIng2.RecipeID = 1;
                recipeIng2.IngredientsID = 2;
                recipeIng2.Quantity = "1 cup";
                RecipeIngredients recipeIng3 = new RecipeIngredients();
                recipeIng3.RecipeID = 1;
                recipeIng3.IngredientsID = 3;
                recipeIng3.Quantity = "10 stone";

                //Act
                RecipeIngredientsController recipeIngredientsController = new RecipeIngredientsController(context, configuration);
                await recipeIngredientsController.Post(recipeIng);
                await recipeIngredientsController.Post(recipeIng2);
                var result = await recipeIngredientsController.Put(1, 3, recipeIng3);

                //Assert
                Assert.IsType<RedirectToActionResult>(result);
            }
        }
        [Fact]
        public async void CannotEditRecipeIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CannotEditRecipeIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                RecipeIngredients recipeIng = new RecipeIngredients();
                recipeIng.RecipeID = 1;
                recipeIng.IngredientsID = 1;
                recipeIng.Quantity = "1 pound";
                RecipeIngredients recipeIng2 = new RecipeIngredients();
                recipeIng2.RecipeID = 1;
                recipeIng2.IngredientsID = 2;
                recipeIng2.Quantity = "1 cup";
                RecipeIngredients recipeIng3 = new RecipeIngredients();
                recipeIng3.RecipeID = 1;
                recipeIng3.IngredientsID = 3;
                recipeIng3.Quantity = "10 stone";

                //Act
                RecipeIngredientsController recipeIngredientsController = new RecipeIngredientsController(context, configuration);
                await recipeIngredientsController.Post(recipeIng);
                await recipeIngredientsController.Post(recipeIng2);
                var result = await recipeIngredientsController.Put(5, 5, recipeIng3);

                //Assert
                Assert.IsType<BadRequestObjectResult>(result);
            }
        }
        [Fact]
        public async void CanEditRecipeIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanEditRecipeIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                RecipeIngredients recipeIng = new RecipeIngredients();
                recipeIng.RecipeID = 1;
                recipeIng.IngredientsID = 1;
                recipeIng.Quantity = "1 pound";
                RecipeIngredients recipeIng2 = new RecipeIngredients();
                recipeIng2.RecipeID = 1;
                recipeIng2.IngredientsID = 2;
                recipeIng2.Quantity = "1 cup";
                RecipeIngredients recipeIng3 = new RecipeIngredients();
                recipeIng3.RecipeID = 1;
                recipeIng3.IngredientsID = 2;
                recipeIng3.Quantity = "10 stone";

                //Act
                RecipeIngredientsController recipeIngredientsController = new RecipeIngredientsController(context, configuration);
                await recipeIngredientsController.Post(recipeIng);
                await recipeIngredientsController.Post(recipeIng2);
                var result = await recipeIngredientsController.Put(1, 2, recipeIng3);

                //Assert
                Assert.IsType<OkObjectResult>(result);
            }
        }
        [Fact]
        public async void CannotGetOneRecipeIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CannotGetOneRecipeIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                RecipeIngredients recipeIng = new RecipeIngredients();
                recipeIng.RecipeID = 1;
                recipeIng.IngredientsID = 1;
                recipeIng.Quantity = "1 pound";
                RecipeIngredients recipeIng2 = new RecipeIngredients();
                recipeIng2.RecipeID = 1;
                recipeIng2.IngredientsID = 2;
                recipeIng2.Quantity = "1 cup";
                RecipeIngredients recipeIng3 = new RecipeIngredients();
                recipeIng3.RecipeID = 1;
                recipeIng3.IngredientsID = 3;
                recipeIng3.Quantity = "10 stone";

                //Act
                RecipeIngredientsController recipeIngredientsController = new RecipeIngredientsController(context, configuration);
                await recipeIngredientsController.Post(recipeIng);
                await recipeIngredientsController.Post(recipeIng2);
                await recipeIngredientsController.Post(recipeIng3);
                var result = recipeIngredientsController.Get(5, 5);

                //Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
        [Fact]
        public async void CanGetOneRecipeIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGetOneRecipeIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                RecipeIngredients recipeIng = new RecipeIngredients();
                recipeIng.RecipeID = 1;
                recipeIng.IngredientsID = 1;
                recipeIng.Quantity = "1 pound";
                RecipeIngredients recipeIng2 = new RecipeIngredients();
                recipeIng2.RecipeID = 1;
                recipeIng2.IngredientsID = 2;
                recipeIng2.Quantity = "1 cup";
                RecipeIngredients recipeIng3 = new RecipeIngredients();
                recipeIng3.RecipeID = 1;
                recipeIng3.IngredientsID = 3;
                recipeIng3.Quantity = "10 stone";

                //Act
                RecipeIngredientsController recipeIngredientsController = new RecipeIngredientsController(context, configuration);
                await recipeIngredientsController.Post(recipeIng);
                await recipeIngredientsController.Post(recipeIng2);
                await recipeIngredientsController.Post(recipeIng3);
                var result = recipeIngredientsController.Get(1, 3);

                //Assert
                Assert.IsType<OkObjectResult>(result);
            }
        }
        [Fact]
        public async void CanGetAllRecipeIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGetAllRecipeIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                RecipeIngredients recipeIng = new RecipeIngredients();
                recipeIng.RecipeID = 1;
                recipeIng.IngredientsID = 1;
                recipeIng.Quantity = "1 pound";
                RecipeIngredients recipeIng2 = new RecipeIngredients();
                recipeIng2.RecipeID = 1;
                recipeIng2.IngredientsID = 2;
                recipeIng2.Quantity = "1 cup";
                RecipeIngredients recipeIng3 = new RecipeIngredients();
                recipeIng3.RecipeID = 1;
                recipeIng3.IngredientsID = 3;
                recipeIng3.Quantity = "10 stone";

                //Act
                RecipeIngredientsController recipeIngredientsController = new RecipeIngredientsController(context, configuration);
                await recipeIngredientsController.Post(recipeIng);
                await recipeIngredientsController.Post(recipeIng2);
                await recipeIngredientsController.Post(recipeIng3);
                var result = recipeIngredientsController.Get().ToList();

                //Assert
                Assert.Equal(3, result.Count);
            }
        }

    }
}
