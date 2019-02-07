using CookBookAPI.Controllers;
using CookBookAPI.Data;
using CookBookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Xunit;

namespace XUnitTestAPITestss
{
    public class InstructionsTests
    {
        private readonly IConfiguration configuration;

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

        [Fact]
        public async void CanCreateInstructions()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanCreateInstructions").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";

                //Act
                InstructionsController InstructionsController = new InstructionsController(context, configuration);
                await InstructionsController.Post(recipe);
                var result = await context.Instructions.FirstOrDefaultAsync(c => c.RecipeID == recipe.RecipeID);

                //Assert
                Assert.Equal(recipe, result);
            }
        }

        [Fact]
        public async void CanGetAllInstructions()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGetAllInstructions").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";
                Instructions recipe2 = new Instructions();
                recipe.RecipeID = 2;
                recipe.StepNumberID = 1;
                recipe.Action = "Mash taters";
                Instructions recipe3 = new Instructions();
                recipe.RecipeID = 3;
                recipe.StepNumberID = 1;
                recipe.Action = "Beat eggs";

                //Act
                InstructionsController InstructionsController = new InstructionsController(context, configuration);
                await InstructionsController.Post(recipe);
                await InstructionsController.Post(recipe2);
                await InstructionsController.Post(recipe3);

                var result = InstructionsController.Get().ToList();

                //Assert
                Assert.Equal(3, result.Count);
            }
        }

        [Fact]
        public async void CanGetOneInstruction()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanGetOneInstruction").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";
                Instructions recipe2 = new Instructions();
                recipe.RecipeID = 2;
                recipe.StepNumberID = 1;
                recipe.Action = "Mash taters";
                Instructions recipe3 = new Instructions();
                recipe.RecipeID = 3;
                recipe.StepNumberID = 1;
                recipe.Action = "Beat eggs";

                //Act
                InstructionsController InstructionsController = new InstructionsController(context, configuration);
                await InstructionsController.Post(recipe);
                await InstructionsController.Post(recipe2);
                await InstructionsController.Post(recipe3);

                var result = InstructionsController.Get(3, 1);

                //Assert
                Assert.IsType<OkObjectResult>(result);
            }
        }

        [Fact]
        public async void CannotGetOneInstruction()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CannotGetOneInstruction").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";
                Instructions recipe2 = new Instructions();
                recipe.RecipeID = 2;
                recipe.StepNumberID = 1;
                recipe.Action = "Mash taters";
                Instructions recipe3 = new Instructions();
                recipe.RecipeID = 3;
                recipe.StepNumberID = 1;
                recipe.Action = "Beat eggs";

                //Act
                InstructionsController InstructionsController = new InstructionsController(context, configuration);
                await InstructionsController.Post(recipe);
                await InstructionsController.Post(recipe2);
                await InstructionsController.Post(recipe3);

                var result = InstructionsController.Get(4, 5);

                //Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }

        [Fact]
        public async void CanEditInstructions()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanEditInstructions").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";
                Instructions recipe2 = new Instructions();
                recipe2.RecipeID = 3;
                recipe2.StepNumberID = 4;
                recipe2.Action = "Mash taters";
                Instructions edit = new Instructions();
                edit.RecipeID = 1;
                edit.StepNumberID = 2;
                edit.Action = "Beat eggs";

                //Act
                InstructionsController instructionsController = new InstructionsController(context, configuration);
                await instructionsController.Post(recipe);
                await instructionsController.Post(recipe2);
                var data = await instructionsController.Put(1, 2, edit);

                //Assert
                Assert.IsType<OkObjectResult>(data);
            }
        }

        [Fact]
        public async void CannotEditInstructions()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CannotEditInstructions").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";
                Instructions recipe2 = new Instructions();
                recipe2.RecipeID = 3;
                recipe2.StepNumberID = 4;
                recipe2.Action = "Mash taters";
                Instructions edit = new Instructions();
                edit.RecipeID = 1;
                edit.StepNumberID = 2;
                edit.Action = "Beat eggs";

                //Act
                InstructionsController instructionsController = new InstructionsController(context, configuration);
                await instructionsController.Post(recipe);
                await instructionsController.Post(recipe2);
                var data = await instructionsController.Put(5, 5, edit);

                //Assert
                Assert.IsType<BadRequestObjectResult>(data);
            }
        }

        [Fact]
        public async void EditMakesNewInstructions()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("EditMakesNewInstructions").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";
                Instructions recipe2 = new Instructions();
                recipe2.RecipeID = 3;
                recipe2.StepNumberID = 4;
                recipe2.Action = "Mash taters";
                Instructions edit = new Instructions();
                edit.RecipeID = 5;
                edit.StepNumberID = 1;
                edit.Action = "Beat eggs";

                //Act
                InstructionsController instructionsController = new InstructionsController(context, configuration);
                await instructionsController.Post(recipe);
                await instructionsController.Post(recipe2);
                var data = await instructionsController.Put(5, 1, edit);

                //Assert
                Assert.IsType<RedirectToActionResult>(data);
            }
        }

        [Fact]
        public async void CanDeleteInstruction()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CanDeleteInstruction").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";
                Instructions recipe2 = new Instructions();
                recipe2.RecipeID = 3;
                recipe2.StepNumberID = 4;
                recipe2.Action = "Mash taters";

                //Act
                InstructionsController instructionsController = new InstructionsController(context, configuration);
                await instructionsController.Post(recipe);
                await instructionsController.Post(recipe2);
                var result = await instructionsController.Delete(1, 2);

                //Assert
                Assert.IsType<OkObjectResult>(result);
            }
        }

        [Fact]
        public async void CannotDeleteInstruction()
        {
            DbContextOptions<CookBookDbContext> options = new DbContextOptionsBuilder<CookBookDbContext>().UseInMemoryDatabase("CannotDeleteInstruction").Options;

            using (CookBookDbContext context = new CookBookDbContext(options))
            {
                //Arrange
                Instructions recipe = new Instructions();
                recipe.RecipeID = 1;
                recipe.StepNumberID = 2;
                recipe.Action = "Boil water";
                Instructions recipe2 = new Instructions();
                recipe2.RecipeID = 3;
                recipe2.StepNumberID = 4;
                recipe2.Action = "Mash taters";

                //Act
                InstructionsController instructionsController = new InstructionsController(context, configuration);
                await instructionsController.Post(recipe);
                await instructionsController.Post(recipe2);
                var result = await instructionsController.Delete(5, 5);

                //Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}
