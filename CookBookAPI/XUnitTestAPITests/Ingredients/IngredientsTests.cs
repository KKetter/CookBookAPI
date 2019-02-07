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
    public class IngredientsTests
    {
        private readonly IConfiguration configuration;

        [Fact]
        public void CanGetID()
        {
            Ingredients recipe = new Ingredients();
            recipe.ID = 80;

            Assert.Equal(80, recipe.ID);
        }
        [Fact]
        public void CanSetID()
        {
            Ingredients recipe = new Ingredients();
            recipe.ID = 80;
            recipe.ID = 60;

            Assert.Equal(60, recipe.ID);
        }
        [Fact]
        public void CanGetName()
        {
            Ingredients recipe = new Ingredients();
            recipe.Name = "Bert";

            Assert.Equal("Bert", recipe.Name);
        }
        [Fact]
        public void CanSetname()
        {
            Ingredients recipe = new Ingredients();
            recipe.Name = "Bert";
            recipe.Name = "Ernie";

            Assert.Equal("Ernie", recipe.Name);
        }
        [Fact]
        public async void CanDeleteIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanDeleteIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Ingredients ingredient = new Ingredients();
                ingredient.ID = 1;
                ingredient.Name = "Swag";
                Ingredients ingredient2 = new Ingredients();
                ingredient2.ID = 2;
                ingredient2.Name = "Energy";

                //Act
                IngredientsController ingredientsController = new IngredientsController(context, configuration);
                await ingredientsController.Post(ingredient);
                await ingredientsController.Post(ingredient2);
                await ingredientsController.Delete(ingredient.ID);
                var result = context.Ingredients.FirstOrDefault(c => c.ID == ingredient.ID);

                //Assert
                Assert.Null(result);
            }
        }
        [Fact]
        public async void CanCreateIngredient()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanCreateIngredient").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Ingredients ingredient = new Ingredients();
                ingredient.ID = 1;
                ingredient.Name = "Swag";

                //Act
                IngredientsController ingredientsController = new IngredientsController(context, configuration);
                await ingredientsController.Post(ingredient);
                var result = context.Ingredients.FirstOrDefault(c => c.ID == ingredient.ID);

                //Assert
                Assert.Equal(ingredient, result);
            }
        }
        [Fact]
        public async void CanEditIngredientToAction()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanEditIngredientToAction").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Ingredients ingredient = new Ingredients();
                ingredient.ID = 1;
                ingredient.Name = "Swag";
                Ingredients ingredient2 = new Ingredients();
                ingredient2.ID = 2;
                ingredient2.Name = "Energy";
                Ingredients ingredient3 = new Ingredients();
                ingredient3.ID = 3;
                ingredient3.Name = "Heart";

                //Act
                IngredientsController ingredientsController = new IngredientsController(context, configuration);
                await ingredientsController.Post(ingredient);
                await ingredientsController.Post(ingredient2);
                var data = await ingredientsController.Put(3, ingredient3);

                //Assert
                Assert.IsType<RedirectToActionResult>(data);
            }
        }
        [Fact]
        public async void CanEditIngredientBadRequest()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanEditIngredientBadRequest").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Ingredients ingredient = new Ingredients();
                ingredient.ID = 1;
                ingredient.Name = "Swag";
                Ingredients ingredient2 = new Ingredients();
                ingredient2.ID = 2;
                ingredient2.Name = "Energy";
                Ingredients ingredient3 = new Ingredients();
                ingredient3.ID = 3;
                ingredient3.Name = "Heart";

                //Act
                IngredientsController ingredientsController = new IngredientsController(context, configuration);
                await ingredientsController.Post(ingredient);
                await ingredientsController.Post(ingredient2);
                var data = await ingredientsController.Put(6, ingredient3);
                
                //Assert
                Assert.IsType<BadRequestObjectResult>(data);
            }
        }
        [Fact]
        public async void CanEditIngredientOk()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanEditIngredientOk").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Ingredients ingredient = new Ingredients();
                ingredient.ID = 1;
                ingredient.Name = "Swag";
                Ingredients ingredient2 = new Ingredients();
                ingredient2.ID = 2;
                ingredient2.Name = "Energy";

                //Act
                IngredientsController ingredientsController = new IngredientsController(context, configuration);
                await ingredientsController.Post(ingredient);
                await ingredientsController.Post(ingredient2);
                var data = await ingredientsController.Put(2, ingredient2);

                //Assert
                Assert.IsType<OkObjectResult>(data);
            }
        }
        [Fact]
        public async void CanGetOneIngredientNotFound()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGetOneIngredientNotFound").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Ingredients ingredient = new Ingredients();
                ingredient.ID = 1;
                ingredient.Name = "Swag";
                Ingredients ingredient2 = new Ingredients();
                ingredient2.ID = 2;
                ingredient2.Name = "Energy";

                //Act
                IngredientsController ingredientsController = new IngredientsController(context, configuration);
                await ingredientsController.Post(ingredient);
                await ingredientsController.Post(ingredient2);
                var data = ingredientsController.Get(6);

                //Assert
                Assert.IsType<NotFoundResult>(data);
            }
        }
        [Fact]
        public async void CanGetOneIngredientOkResult()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGetOneIngredientOkResult").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Ingredients ingredient = new Ingredients();
                ingredient.ID = 1;
                ingredient.Name = "Swag";
                Ingredients ingredient2 = new Ingredients();
                ingredient2.ID = 2;
                ingredient2.Name = "Energy";

                //Act
                IngredientsController ingredientsController = new IngredientsController(context, configuration);
                await ingredientsController.Post(ingredient);
                await ingredientsController.Post(ingredient2);
                var data = ingredientsController.Get(2);

                //Assert
                Assert.IsType<OkObjectResult>(data);
            }
        }

    }
}
