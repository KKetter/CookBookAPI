using CookBookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookAPI.Data
{
    public class CookBookDbContext : DbContext
    {
        public CookBookDbContext(DbContextOptions<CookBookDbContext> options) : base (options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredients>().HasKey(ri => new { ri.RecipeID, ri.IngredientsID, });
            modelBuilder.Entity<Instructions>().HasKey(i => new { i.RecipeID, i.StepNumberID, });

            modelBuilder.Entity<Recipes>().HasData(
                new Recipes()
                {
                    ID = 1,
                    Name = "White Chicken Chili",
                },
                new Recipes()
                {
                    ID = 2,
                    Name = "Shortbread Cookies",
                },
                new Recipes()
                {
                    ID = 3,
                    Name = "Buffalo Chicken Meatloaf Cupcakes",
                }
            );

            modelBuilder.Entity<Ingredients>().HasData(
                new Ingredients()
                {
                    ID = 1,
                    Name = "Olive Oil",
                },
                new Ingredients()
                {
                    ID = 2,
                    Name = "Chicken Breast",
                },
                new Ingredients()
                {
                    ID = 3,
                    Name = "White Onion",
                },
                new Ingredients()
                {
                    ID = 4,
                    Name = "Garlic",
                },
                new Ingredients()
                {
                    ID = 5,
                    Name = "Chicken Broth",
                },
                new Ingredients()
                {
                    ID = 6,
                    Name = "White Kidney Beans",
                },
                new Ingredients()
                {
                    ID = 7,
                    Name = "Green Chilies",
                },
                new Ingredients()
                {
                    ID = 8,
                    Name = "Dried Oregano",
                },
                new Ingredients()
                {
                    ID = 9,
                    Name = "Ground Cumin",
                },
                new Ingredients()
                {
                    ID = 10,
                    Name = "Cayenne Pepper",
                },
                new Ingredients()
                {
                    ID = 11,
                    Name = "Fresh Cilanto",
                },
                new Ingredients()
                {
                    ID = 12,
                    Name = "Monterey Jack Cheese",
                },
                new Ingredients()
                {
                    ID = 13,
                    Name = "Salt",
                },
                new Ingredients()
                {
                    ID = 14,
                    Name = "Unsalted Butter",
                },
                new Ingredients()
                {
                    ID = 15,
                    Name = "White Sugar",
                },
                new Ingredients()
                {
                    ID = 16,
                    Name = "Vanilla Extract",
                },
                new Ingredients()
                {
                    ID = 17,
                    Name = "All-Purpose Flour",
                },
                new Ingredients()
                {
                    ID = 18,
                    Name = "Hot Sauce",
                },
                new Ingredients()
                {
                    ID = 19,
                    Name = " Worcestershire Sauce",
                },
                new Ingredients()
                {
                    ID = 20,
                    Name = "White Vinegar",
                },
                new Ingredients()
                {
                    ID = 21,
                    Name = "Celery",
                },
                new Ingredients()
                {
                    ID = 22,
                    Name = "Ground Chicken",
                },
                new Ingredients()
                {
                    ID = 23,
                    Name = "Pork Rinds",
                },
                new Ingredients()
                {
                    ID = 24,
                    Name = "Egg",
                },
                new Ingredients()
                {
                    ID = 25,
                    Name = "Unflavored Gelatin",
                },
                new Ingredients()
                {
                    ID = 26,
                    Name = "Celery Seed",
                },
                new Ingredients()
                {
                    ID = 27,
                    Name = "Blue Cheese",
                }
            );

            modelBuilder.Entity<RecipeIngredients>().HasData(
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 1,
                    Quantity = "1 tablespoon"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 2,
                    Quantity = "3 skinless, boneless halved"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 3,
                    Quantity = "1 large, chopped"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 4,
                    Quantity = "2 cloves, minced"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 5,
                    Quantity = "5 1/4 cups"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 6,
                    Quantity = "15 oz"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 7,
                    Quantity = "4 oz"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 8,
                    Quantity = "1 tablespoon"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 9,
                    Quantity = "1 teaspoon"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 10,
                    Quantity = "2 pinches"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 11,
                    Quantity = "1/4 cup, chopped"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 12,
                    Quantity = "1/2 cup shredded"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 13,
                    Quantity = "to taste"
                },
                new RecipeIngredients()
                {
                RecipeID = 2,
                    IngredientsID = 14,
                    Quantity = "2 cups, softened"
                },
                new RecipeIngredients()
                {
                    RecipeID = 2,
                    IngredientsID = 15,
                    Quantity = "1 cup"
                },
                new RecipeIngredients()
                {
                    RecipeID = 2,
                    IngredientsID = 16,
                    Quantity = "2 teaspoons"
                },
                new RecipeIngredients()
                {
                    RecipeID = 2,
                    IngredientsID = 17,
                    Quantity = "4 cups"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 14,
                    Quantity = "4 tablespoons"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 4,
                    Quantity = "3 medium cloves"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 18,
                    Quantity = "2/3 cup"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 19,
                    Quantity = "2 teaspoons"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 20,
                    Quantity = "1 1/2 tablespoons"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 1,
                    Quantity = "1 tablespoon"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 3,
                    Quantity = "1/2 medium, diced"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 21,
                    Quantity = "1 rib, minced"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 22,
                    Quantity = "1 pound"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 23,
                    Quantity = "1/2 cup crushed"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 24,
                    Quantity = "1 large"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 5,
                    Quantity = "2 tablespoons"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 25,
                    Quantity = "1/2 teaspoon"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 26,
                    Quantity = "1/4 teaspoon"
                },
                new RecipeIngredients()
                {
                    RecipeID = 3,
                    IngredientsID = 27,
                    Quantity = "2 ounces"
                }
            );

            modelBuilder.Entity<Instructions>().HasData(
                new Instructions()
                {
                    RecipeID = 1,
                    StepNumberID = 1,
                    Action = "Heat olive oil in a Dutch oven over medium heat. Cook chicken, onion, and garlic in hot oil until the chicken is browned completely, 3 to 5 minutes per side."
                },
                new Instructions()
                {
                    RecipeID = 1,
                    StepNumberID = 2,
                    Action = "Remove the chicken to a cutting board, cut into 1-inch pieces, and return to the Dutch oven; add chicken broth, cannellini, green chilies, oregano, cumin, and cayenne pepper. Bring the mixture to a simmer and cook until the chicken is cooked through, 30 to 45 minutes."
                },
                new Instructions()
                {
                    RecipeID = 1,
                    StepNumberID = 3,
                    Action = "Divide cilantro among 4 bowls. Ladle chili over cilantro and top with cheese. Season with salt to serve."
                },
                new Instructions()
                {
                    RecipeID = 2,
                    StepNumberID = 1,
                    Action = "Preheat oven to 350 degrees F (180 degrees C)."
                },
                new Instructions()
                {
                    RecipeID = 2,
                    StepNumberID = 2,
                    Action = "Cream butter and sugar until fluffy. Stir in vanilla; add flour and mix well."
                },
                new Instructions()
                {
                    RecipeID = 2,
                    StepNumberID = 3,
                    Action = "Put through cookie press and form cookies onto baking sheets. Bake for 10 - 12 minutes."
                },
                new Instructions()
                {
                    RecipeID = 3,
                    StepNumberID = 1,
                    Action = "Melt 1 1/2 tablespoons butter in a saucepan over low heat. Add 1 medium clove, minced garlic and cook for about a minute.  Add hot sauce, 1 teaspoon Worcestershire sauce, vinegar, salt and pepper to taste. Whisk to combine then simmer for a bit before setting aside."
                },
                new Instructions()
                {
                    RecipeID = 3,
                    StepNumberID = 2,
                    Action = "Heat the olive oil for the chicken in a skillet over medium heat. Add the onion, celery, and minced garlic.  Cook until softened then set aside to cool."
                },
                new Instructions()
                {
                    RecipeID = 3,
                    StepNumberID = 3,
                    Action = "Preheat oven to 375°F. Whisk eggs and chicken stock in a medium bowl. Add the gelatin then allow to bloom for 5 minutes."
                },
                new Instructions()
                {
                    RecipeID = 3,
                    StepNumberID = 4,
                    Action = "Add chicken, Worcestershire sauce, celery seed, pork rinds, salt, pepper, and 1/4 of the prepared wing sauce to the bowl with the onion mixture. Add the eggs then mix to combine."
                },
                new Instructions()
                {
                    RecipeID = 3,
                    StepNumberID = 5,
                    Action = "Spray the compartments of a cupcake tin with cooking spray. Add about 2 tablespoons of meatloaf mixture per well, then press a space into the center of each one for the fillings. Add blue cheese and top with a slice of butter. Top with the remaining meat and brush the wing sauce on top. Transfer the tray to the oven and bake. Brush more sauce on top every ten minutes, baking for 25 minutes."
                }
            );
        }

        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Instructions> Instructions { get; set; }
    }
}
