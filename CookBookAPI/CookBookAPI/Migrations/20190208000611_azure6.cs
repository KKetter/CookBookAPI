using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CookBookAPI.Migrations
{
    public partial class azure6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    RecipeID = table.Column<int>(nullable: false),
                    StepNumberID = table.Column<int>(nullable: false),
                    Action = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => new { x.RecipeID, x.StepNumberID });
                    table.ForeignKey(
                        name: "FK_Instructions_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeID = table.Column<int>(nullable: false),
                    IngredientsID = table.Column<int>(nullable: false),
                    Quantity = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeID, x.IngredientsID });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientsID",
                        column: x => x.IngredientsID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Olive Oil" },
                    { 23, "Pork Rinds" },
                    { 24, "Egg" },
                    { 25, "Unflavored Gelatin" },
                    { 26, "Celery Seed" },
                    { 27, "Blue Cheese" },
                    { 28, "Elbow Pasta" },
                    { 29, "Unsalted Butter" },
                    { 21, "Celery" },
                    { 30, "All Purpose Flour" },
                    { 32, "Half and Half" },
                    { 33, "Medium Sharp Cheddar Cheese" },
                    { 34, "Gruyere Cheese" },
                    { 35, "Black Pepper" },
                    { 36, "Paprika" },
                    { 37, "Baking Powder" },
                    { 38, "Granulated Sugar" },
                    { 31, "Whole Milk" },
                    { 20, "White Vinegar" },
                    { 22, "Ground Chicken" },
                    { 18, "Hot Sauce" },
                    { 2, "Chicken Breast" },
                    { 3, "White Onion" },
                    { 4, "Garlic" },
                    { 5, "Chicken Broth" },
                    { 6, "White Kidney Beans" },
                    { 7, "Green Chilies" },
                    { 19, " Worcestershire Sauce" },
                    { 9, "Ground Cumin" },
                    { 8, "Dried Oregano" },
                    { 11, "Fresh Cilanto" },
                    { 12, "Monterey Jack Cheese" },
                    { 13, "Salt" },
                    { 14, "Unsalted Butter" },
                    { 15, "White Sugar" },
                    { 16, "Vanilla Extract" },
                    { 17, "All-Purpose Flour" },
                    { 10, "Cayenne Pepper" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "ID", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 4, "https://goo.gl/images/MNwsmA", "Baked Mac N Cheese" },
                    { 1, "https://lh3.googleusercontent.com/t6E4pJFAevAGqReny5IrPYOAw0CQzM2ntvjqbdARtE0MHBOrOPgcFYCKm-25YQ0o45tCF-Fv6HAqoWr03g_QSXDfGs1qMRsfeXeGKM4OKWoz3L850SN8wihPYKGFMEjQCdNox5ZHkCMXKX2iwQire-h6cG_w1PrVyUkKXJqKN7q5bRRb-yQ70a_ALCcWLYttlBJl-MB_CGoXE_KpuV6wTsPYt1sWzhwUo-rrx97QT-QcTu1OIF1VxVxDTnkNE-U8yRWV6ONjJT1qzZx1j4ek8mEEUGhLQuCfSYMbR-3wPlDHtbWS2Kk4TJMyj6E08rslaFQh6xoHcLlGFrsEz4Iao26aUMLYU-WMWTuNHTwU8T2jfYin40VrUgtjaRX9SpPurdlaGR2bIWnu09rw-9FYLCneabM5Ok56AqxucR2pairb6NBMifNevr6_aErXx2SkWaDatsrUHbmlMupI5xZOikPPSAKbyg2AXzZY9tuBT4oM4HZG_20jXs8VK5j8xD4L6-6Zc4srak9hPgBexhB0to4ODG7-JEA4BHfAB0E8Rvfm9mxhUYbF2-lWGuHM1kj_ZNqsz9K97EtfReQ5jFn61ASD7mlcABdaNfsKaRbcy6u-2fqYbdvHBOcn0bUvc5woTM7T7rHym4nDdSZ_CKADzr4-C9oAWWRjPDY13LaRpqNDKmGHcXq3Mc5giQvlR6k4Bo7Q10pFrdJ66yYLG5U4RuG6=w600-h900-no", "White Chicken Chili" },
                    { 2, "https://lh3.googleusercontent.com/ZtSoWRoG4_ZVEPcSYcBmFDT6PUrMP7Rc5uhMRKPurDKdHK9n4CHw0YGFfWMKnH0viBqTdlGijYsPkXw4doWEtQxuwa7e1Sun7p4Uzto1KGwQBGc0taM3Fe61mYpdW7dTHRBcR_mkDtZOn8ByjQq8oQA9yY3gVAxev3qMNzFvHlCfVdEx3UfmDh-ymuip0dRNyscf8-vwUd-sSoqUe-4H5lNjWNTp7dvIot7jcSZ3AMkbgCcikE8u-CsyhTTHzb4RPqVyQkfG214wXcmA6CicPCA2WTn5idRmSP7crWx7HVR1fsF3OS-L4_IVCVCppsZloDqHwk3EFhb7xcBWlFO8iKFND4cUjq-ArKU7vr4WbAEPrEZk4nWo08MZKXP3-pkSdZ0D8FlTuBvC4vqyYv75_Gj1rDAGPxMMjexfDMDB47czoaxUWWyNvWs5OZPATHEP_XG6mqK3Boh_ZZn9KgodXsLkxPZ4DmB58xJMcS0HfzsYHKIkoEoN9fQhvYDVwMePYinR4_A_lVoWg8wtXuwjoFyMsUzSQvRapLV5BV7Jo11rrNBv8NJJCke7rINwNkBtt0pVK-Jb-YstRWhU-MVGix7TjHCYE7bHzgNoQG9h-2AinYNGHkBrk1I4xuOP1aZCUYspr0ArJlEzyRFdJ2wQvR1hjWgsPV1MHAQIs4GUNrXsragrvmDq9FAbaSF3mybvi9MHXFPSiP58ID6kcGe3nsQX=w689-h915-no", "Shortbread Cookies" },
                    { 3, "https://goo.gl/images/JkTjTQ", "Buffalo Chicken Meatloaf Cupcakes" },
                    { 5, "https://images.media-allrecipes.com/userphotos/720x405/5011529.jpg", "Dumplings" }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "RecipeID", "StepNumberID", "Action" },
                values: new object[,]
                {
                    { 1, 1, "Heat olive oil in a Dutch oven over medium heat. Cook chicken, onion, and garlic in hot oil until the chicken is browned completely, 3 to 5 minutes per side." },
                    { 3, 3, "Preheat oven to 375°F. Whisk eggs and chicken stock in a medium bowl. Add the gelatin then allow to bloom for 5 minutes." },
                    { 3, 4, "Add chicken, Worcestershire sauce, celery seed, pork rinds, salt, pepper, and 1/4 of the prepared wing sauce to the bowl with the onion mixture. Add the eggs then mix to combine." },
                    { 2, 3, "Put through cookie press and form cookies onto baking sheets. Bake for 10 - 12 minutes." },
                    { 2, 2, "Cream butter and sugar until fluffy. Stir in vanilla; add flour and mix well." },
                    { 2, 1, "Preheat oven to 350 degrees F (180 degrees C)." },
                    { 3, 5, "Spray the compartments of a cupcake tin with cooking spray. Add about 2 tablespoons of meatloaf mixture per well, then press a space into the center of each one for the fillings. Add blue cheese and top with a slice of butter. Top with the remaining meat and brush the wing sauce on top. Transfer the tray to the oven and bake. Brush more sauce on top every ten minutes, baking for 25 minutes." },
                    { 4, 8, "Sprinkle the top with the last 1 1/2 cups of cheese and bake for 15 minutes, until cheesy is bubbly and lightly golden brown." },
                    { 4, 7, "In a large mixing bowl, combine drained pasta with cheese sauce, stirring to combine fully.  Pour half of the pasta mixture into the prepared baking dish.  Top with 1 1/2 cups of grated cheeses, then top that with the remaining pasta mixture." },
                    { 4, 6, "Stir in spices and 1 1/2 cups of the cheeses, stirring to melt and combine.  Stir in another 1 1/2 cups of cheese, and stir until completely melted and smooth." },
                    { 3, 2, "Heat the olive oil for the chicken in a skillet over medium heat. Add the onion, celery, and minced garlic.  Cook until softened then set aside to cool." },
                    { 4, 5, "Continue to heat over MED heat, whisking very often, until thickened to a very thick consistency.  It should almost be the consistency of a semi thinned out condensed soup." },
                    { 5, 1, "Stir together flour, baking powder, sugar, and salt in medium size bowl. Cut in butter until crumbly. Stir in milk to make a soft dough." },
                    { 5, 2, "Drop by spoonfuls into boiling stew. Cover and simmer 15 minutes without lifting lid. Serve." },
                    { 5, 3, "To make parsley dumplings, add 1 tablespoon parsley flakes to the dry ingredients." },
                    { 4, 3, "While water is coming up to a boil, grate cheeses and toss together to mix, then divide into three piles.  Approximately 3 cups for the sauce, 1 1/2 cups for the inner layer, and 1 1/2 cups for the topping." },
                    { 4, 2, "Bring a large pot of salted water to a boil.  When boiling, add dried pasta and cook 1 minute less than the package directs for al dente.  Drain and drizzle with a little bit of olive oil to keep from sticking." },
                    { 4, 1, "Preheat oven to 325 degrees F and grease a 3 qt baking dish (9x13). Set aside." },
                    { 1, 3, "Divide cilantro among 4 bowls. Ladle chili over cilantro and top with cheese. Season with salt to serve." },
                    { 1, 2, "Remove the chicken to a cutting board, cut into 1-inch pieces, and return to the Dutch oven; add chicken broth, cannellini, green chilies, oregano, cumin, and cayenne pepper. Bring the mixture to a simmer and cook until the chicken is cooked through, 30 to 45 minutes." },
                    { 4, 4, "Melt butter in a large saucepan over MED heat.  Sprinkle in flour and whisk to combine.  Mixture will look like very wet sand.  Cook for approximately 1 minute, whisking often.  Slowly pour in about 2 cups or so of the milk/half and half, while whisking constantly, until smooth.  Slowly pour in the remaining milk/half and half, while whisking constantly, until combined and smooth." },
                    { 3, 1, "Melt 1 1/2 tablespoons butter in a saucepan over low heat. Add 1 medium clove, minced garlic and cook for about a minute.  Add hot sauce, 1 teaspoon Worcestershire sauce, vinegar, salt and pepper to taste. Whisk to combine then simmer for a bit before setting aside." }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "RecipeID", "IngredientsID", "Quantity" },
                values: new object[,]
                {
                    { 3, 27, "2 ounces" },
                    { 4, 31, "1 and 1/2 cups" },
                    { 4, 29, "1 stick" },
                    { 4, 30, "1/2 cup" },
                    { 3, 26, "1/4 teaspoon" },
                    { 4, 32, "2 and 1/2 cups" },
                    { 4, 33, "4 cups grated" },
                    { 4, 34, "2 cups grated" },
                    { 4, 13, "1/2 tbsp" },
                    { 4, 35, "1/2 tsp" },
                    { 4, 36, "1/4 tsp" },
                    { 5, 17, "1 cup" },
                    { 5, 37, "2 tsp" },
                    { 5, 38, "1 tsp" },
                    { 5, 13, "1/2 tsp" },
                    { 4, 28, "1 pound" },
                    { 3, 25, "1/2 teaspoon" },
                    { 3, 3, "1/2 medium, diced" },
                    { 3, 24, "1 large" },
                    { 1, 1, "1 tablespoon" },
                    { 1, 2, "3 skinless, boneless halved" },
                    { 1, 3, "1 large, chopped" },
                    { 1, 4, "2 cloves, minced" },
                    { 1, 5, "5 1/4 cups" },
                    { 1, 6, "15 oz" },
                    { 1, 7, "4 oz" },
                    { 1, 8, "1 tablespoon" },
                    { 1, 9, "1 teaspoon" },
                    { 1, 10, "2 pinches" },
                    { 1, 11, "1/4 cup, chopped" },
                    { 1, 12, "1/2 cup shredded" },
                    { 1, 13, "to taste" },
                    { 2, 14, "2 cups, softened" },
                    { 2, 15, "1 cup" },
                    { 2, 16, "2 teaspoons" },
                    { 2, 17, "4 cups" },
                    { 3, 14, "4 tablespoons" },
                    { 3, 4, "3 medium cloves" },
                    { 3, 18, "2/3 cup" },
                    { 3, 19, "2 teaspoons" },
                    { 3, 20, "1 1/2 tablespoons" },
                    { 3, 1, "1 tablespoon" },
                    { 5, 14, "1 tbsp" },
                    { 3, 21, "1 rib, minced" },
                    { 3, 22, "1 pound" },
                    { 3, 23, "1/2 cup crushed" },
                    { 3, 5, "2 tablespoons" },
                    { 5, 31, "1/2 cup" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientsID",
                table: "RecipeIngredients",
                column: "IngredientsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
