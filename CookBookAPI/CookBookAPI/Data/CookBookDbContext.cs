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
                    ImageURL = "https://lh3.googleusercontent.com/t6E4pJFAevAGqReny5IrPYOAw0CQzM2ntvjqbdARtE0MHBOrOPgcFYCKm-25YQ0o45tCF-Fv6HAqoWr03g_QSXDfGs1qMRsfeXeGKM4OKWoz3L850SN8wihPYKGFMEjQCdNox5ZHkCMXKX2iwQire-h6cG_w1PrVyUkKXJqKN7q5bRRb-yQ70a_ALCcWLYttlBJl-MB_CGoXE_KpuV6wTsPYt1sWzhwUo-rrx97QT-QcTu1OIF1VxVxDTnkNE-U8yRWV6ONjJT1qzZx1j4ek8mEEUGhLQuCfSYMbR-3wPlDHtbWS2Kk4TJMyj6E08rslaFQh6xoHcLlGFrsEz4Iao26aUMLYU-WMWTuNHTwU8T2jfYin40VrUgtjaRX9SpPurdlaGR2bIWnu09rw-9FYLCneabM5Ok56AqxucR2pairb6NBMifNevr6_aErXx2SkWaDatsrUHbmlMupI5xZOikPPSAKbyg2AXzZY9tuBT4oM4HZG_20jXs8VK5j8xD4L6-6Zc4srak9hPgBexhB0to4ODG7-JEA4BHfAB0E8Rvfm9mxhUYbF2-lWGuHM1kj_ZNqsz9K97EtfReQ5jFn61ASD7mlcABdaNfsKaRbcy6u-2fqYbdvHBOcn0bUvc5woTM7T7rHym4nDdSZ_CKADzr4-C9oAWWRjPDY13LaRpqNDKmGHcXq3Mc5giQvlR6k4Bo7Q10pFrdJ66yYLG5U4RuG6=w600-h900-no"
                },
                new Recipes()
                {
                    ID = 2,
                    Name = "Shortbread Cookies",
                    ImageURL = "https://lh3.googleusercontent.com/ZtSoWRoG4_ZVEPcSYcBmFDT6PUrMP7Rc5uhMRKPurDKdHK9n4CHw0YGFfWMKnH0viBqTdlGijYsPkXw4doWEtQxuwa7e1Sun7p4Uzto1KGwQBGc0taM3Fe61mYpdW7dTHRBcR_mkDtZOn8ByjQq8oQA9yY3gVAxev3qMNzFvHlCfVdEx3UfmDh-ymuip0dRNyscf8-vwUd-sSoqUe-4H5lNjWNTp7dvIot7jcSZ3AMkbgCcikE8u-CsyhTTHzb4RPqVyQkfG214wXcmA6CicPCA2WTn5idRmSP7crWx7HVR1fsF3OS-L4_IVCVCppsZloDqHwk3EFhb7xcBWlFO8iKFND4cUjq-ArKU7vr4WbAEPrEZk4nWo08MZKXP3-pkSdZ0D8FlTuBvC4vqyYv75_Gj1rDAGPxMMjexfDMDB47czoaxUWWyNvWs5OZPATHEP_XG6mqK3Boh_ZZn9KgodXsLkxPZ4DmB58xJMcS0HfzsYHKIkoEoN9fQhvYDVwMePYinR4_A_lVoWg8wtXuwjoFyMsUzSQvRapLV5BV7Jo11rrNBv8NJJCke7rINwNkBtt0pVK-Jb-YstRWhU-MVGix7TjHCYE7bHzgNoQG9h-2AinYNGHkBrk1I4xuOP1aZCUYspr0ArJlEzyRFdJ2wQvR1hjWgsPV1MHAQIs4GUNrXsragrvmDq9FAbaSF3mybvi9MHXFPSiP58ID6kcGe3nsQX=w689-h915-no"
                },
                new Recipes()
                {
                    ID = 3,
                    Name = "Buffalo Chicken Meatloaf Cupcakes",
                    ImageURL = "https://goo.gl/images/JkTjTQ"
                },
                new Recipes()
                {
                    ID = 4,
                    Name = "Baked Mac N Cheese",
                    ImageURL = "https://goo.gl/images/MNwsmA"
                },
                new Recipes()
                {
                    ID = 5,
                    Name = "Dumplings",
                    ImageURL = "https://images.media-allrecipes.com/userphotos/720x405/5011529.jpg"
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
                },
                new Ingredients()
                {
                    ID = 28,
                    Name = "Elbow Pasta",
                },
                new Ingredients()
                {
                    ID = 29,
                    Name = "Unsalted Butter",
                },
                new Ingredients()
                {
                    ID = 30,
                    Name = "All Purpose Flour",
                },
                new Ingredients()
                {
                    ID = 31,
                    Name = "Whole Milk",
                },
                new Ingredients()
                {
                    ID = 32,
                    Name = "Half and Half",
                },
                new Ingredients()
                {
                    ID = 33,
                    Name = "Medium Sharp Cheddar Cheese",
                },
                new Ingredients()
                {
                    ID = 34,
                    Name = "Gruyere Cheese",
                },
                new Ingredients()
                {
                    ID = 35,
                    Name = "Black Pepper",
                },
                new Ingredients()
                {
                    ID = 36,
                    Name = "Paprika",
                },
                new Ingredients()
                {
                    ID = 37,
                    Name = "Baking Powder",
                },
                new Ingredients()
                {
                    ID = 38,
                    Name = "Granulated Sugar",
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
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 28,
                    Quantity = "1 pound"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 29,
                    Quantity = "1 stick"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 30,
                    Quantity = "1/2 cup"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 31,
                    Quantity = "1 and 1/2 cups"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 32,
                    Quantity = "2 and 1/2 cups"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 33,
                    Quantity = "4 cups grated"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 34,
                    Quantity = "2 cups grated"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 13,
                    Quantity = "1/2 tbsp"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 35,
                    Quantity = "1/2 tsp"
                },
                new RecipeIngredients()
                {
                    RecipeID = 4,
                    IngredientsID = 36,
                    Quantity = "1/4 tsp"
                },
                new RecipeIngredients()
                {
                    RecipeID = 5,
                    IngredientsID = 17,
                    Quantity = "1 cup"
                },
                new RecipeIngredients()
                {
                    RecipeID = 5,
                    IngredientsID = 37,
                    Quantity = "2 tsp"
                },
                new RecipeIngredients()
                {
                    RecipeID = 5,
                    IngredientsID = 38,
                    Quantity = "1 tsp"
                },
                new RecipeIngredients()
                {
                    RecipeID = 5,
                    IngredientsID = 13,
                    Quantity = "1/2 tsp"
                },
                new RecipeIngredients()
                {
                    RecipeID = 5,
                    IngredientsID = 14,
                    Quantity = "1 tbsp"
                },
                new RecipeIngredients()
                {
                    RecipeID = 5,
                    IngredientsID = 31,
                    Quantity = "1/2 cup"
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
                },
                new Instructions()
                {
                    RecipeID = 4,
                    StepNumberID = 1,
                    Action = "Preheat oven to 325 degrees F and grease a 3 qt baking dish (9x13). Set aside."
                },
                new Instructions()
                {
                    RecipeID = 4,
                    StepNumberID = 2,
                    Action = "Bring a large pot of salted water to a boil.  When boiling, add dried pasta and cook 1 minute less than the package directs for al dente.  Drain and drizzle with a little bit of olive oil to keep from sticking."
                },
                new Instructions()
                {
                    RecipeID = 4,
                    StepNumberID = 3,
                    Action = "While water is coming up to a boil, grate cheeses and toss together to mix, then divide into three piles.  Approximately 3 cups for the sauce, 1 1/2 cups for the inner layer, and 1 1/2 cups for the topping."
                },
                new Instructions()
                {
                    RecipeID = 4,
                    StepNumberID = 4,
                    Action = "Melt butter in a large saucepan over MED heat.  Sprinkle in flour and whisk to combine.  Mixture will look like very wet sand.  Cook for approximately 1 minute, whisking often.  Slowly pour in about 2 cups or so of the milk/half and half, while whisking constantly, until smooth.  Slowly pour in the remaining milk/half and half, while whisking constantly, until combined and smooth."
                },
                new Instructions()
                {
                    RecipeID = 4,
                    StepNumberID = 5,
                    Action = "Continue to heat over MED heat, whisking very often, until thickened to a very thick consistency.  It should almost be the consistency of a semi thinned out condensed soup."
                },
                new Instructions()
                {
                    RecipeID = 4,
                    StepNumberID = 6,
                    Action = "Stir in spices and 1 1/2 cups of the cheeses, stirring to melt and combine.  Stir in another 1 1/2 cups of cheese, and stir until completely melted and smooth."
                },
                new Instructions()
                {
                    RecipeID = 4,
                    StepNumberID = 7,
                    Action = "In a large mixing bowl, combine drained pasta with cheese sauce, stirring to combine fully.  Pour half of the pasta mixture into the prepared baking dish.  Top with 1 1/2 cups of grated cheeses, then top that with the remaining pasta mixture."
                },
                new Instructions()
                {
                    RecipeID = 4,
                    StepNumberID = 8,
                    Action = "Sprinkle the top with the last 1 1/2 cups of cheese and bake for 15 minutes, until cheesy is bubbly and lightly golden brown."
                },
                new Instructions()
                {
                    RecipeID = 5,
                    StepNumberID = 1,
                    Action = "Stir together flour, baking powder, sugar, and salt in medium size bowl. Cut in butter until crumbly. Stir in milk to make a soft dough."
                },
                new Instructions()
                {
                    RecipeID = 5,
                    StepNumberID = 2,
                    Action = "Drop by spoonfuls into boiling stew. Cover and simmer 15 minutes without lifting lid. Serve."
                },
                new Instructions()
                {
                    RecipeID = 5,
                    StepNumberID = 3,
                    Action = "To make parsley dumplings, add 1 tablespoon parsley flakes to the dry ingredients."
                }
            );
        }

        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Instructions> Instructions { get; set; }
    }
}
