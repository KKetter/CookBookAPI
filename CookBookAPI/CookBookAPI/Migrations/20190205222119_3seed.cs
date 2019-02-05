using Microsoft.EntityFrameworkCore.Migrations;

namespace CookBookAPI.Migrations
{
    public partial class _3seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Olive Oil");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Chicken Breast");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 27, "Blue Cheese" },
                    { 26, "Celery Seed" },
                    { 25, "Unflavored Gelatin" },
                    { 24, "Egg" },
                    { 23, "Pork Rinds" },
                    { 22, "Ground Chicken" },
                    { 21, "Celery" },
                    { 20, "White Vinegar" },
                    { 19, " Worcestershire Sauce" },
                    { 17, "All-Purpose Flour" },
                    { 16, "Vanilla Extract" },
                    { 15, "White Sugar" },
                    { 18, "Hot Sauce" },
                    { 13, "Salt" },
                    { 3, "White Onion" },
                    { 4, "Garlic" },
                    { 14, "Unsalted Butter" },
                    { 6, "White Kidney Beans" },
                    { 7, "Green Chilies" },
                    { 5, "Chicken Broth" },
                    { 9, "Ground Cumin" },
                    { 10, "Cayenne Pepper" },
                    { 11, "Fresh Cilanto" },
                    { 12, "Monterey Jack Cheese" },
                    { 8, "Dried Oregano" }
                });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 1, 1 },
                column: "Action",
                value: "Heat olive oil in a Dutch oven over medium heat. Cook chicken, onion, and garlic in hot oil until the chicken is browned completely, 3 to 5 minutes per side.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 1, 2 },
                column: "Action",
                value: "Remove the chicken to a cutting board, cut into 1-inch pieces, and return to the Dutch oven; add chicken broth, cannellini, green chilies, oregano, cumin, and cayenne pepper. Bring the mixture to a simmer and cook until the chicken is cooked through, 30 to 45 minutes.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 1, 3 },
                column: "Action",
                value: "Divide cilantro among 4 bowls. Ladle chili over cilantro and top with cheese. Season with salt to serve.");

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 1 },
                column: "Quantity",
                value: "1 tablespoon");

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 2 },
                column: "Quantity",
                value: "3 skinless, boneless halved");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "White Chicken Chili");

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 2, "Shortbread Cookies" },
                    { 3, "Buffalo Chicken Meatloaf Cupcakes" }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "RecipeID", "StepNumberID", "Action" },
                values: new object[,]
                {
                    { 3, 1, "Melt 1 1/2 tablespoons butter in a saucepan over low heat. Add 1 medium clove, minced garlic and cook for about a minute.  Add hot sauce, 1 teaspoon Worcestershire sauce, vinegar, salt and pepper to taste. Whisk to combine then simmer for a bit before setting aside." },
                    { 3, 4, "Add chicken, Worcestershire sauce, celery seed, pork rinds, salt, pepper, and 1/4 of the prepared wing sauce to the bowl with the onion mixture. Add the eggs then mix to combine." },
                    { 3, 5, "Spray the compartments of a cupcake tin with cooking spray. Add about 2 tablespoons of meatloaf mixture per well, then press a space into the center of each one for the fillings. Add blue cheese and top with a slice of butter. Top with the remaining meat and brush the wing sauce on top. Transfer the tray to the oven and bake. Brush more sauce on top every ten minutes, baking for 25 minutes." },
                    { 2, 3, "Put through cookie press and form cookies onto baking sheets. Bake for 10 - 12 minutes." },
                    { 2, 2, "Cream butter and sugar until fluffy. Stir in vanilla; add flour and mix well." },
                    { 2, 1, "Preheat oven to 350 degrees F (180 degrees C)." },
                    { 3, 2, "Heat the olive oil for the chicken in a skillet over medium heat. Add the onion, celery, and minced garlic.  Cook until softened then set aside to cool." },
                    { 3, 3, "Preheat oven to 375°F. Whisk eggs and chicken stock in a medium bowl. Add the gelatin then allow to bloom for 5 minutes." }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "RecipeID", "IngredientsID", "Quantity" },
                values: new object[,]
                {
                    { 3, 1, "1 tablespoon" },
                    { 3, 20, "1 1/2 tablespoons" },
                    { 3, 21, "1 rib, minced" },
                    { 3, 22, "1 pound" },
                    { 3, 23, "1/2 cup crushed" },
                    { 3, 24, "1 large" },
                    { 3, 18, "2/3 cup" },
                    { 3, 4, "3 medium cloves" },
                    { 3, 14, "4 tablespoons" },
                    { 3, 5, "2 tablespoons" },
                    { 3, 25, "1/2 teaspoon" },
                    { 3, 3, "1/2 medium, diced" },
                    { 3, 19, "2 teaspoons" },
                    { 1, 3, "1 large, chopped" },
                    { 2, 17, "4 cups" },
                    { 2, 16, "2 teaspoons" },
                    { 2, 15, "1 cup" },
                    { 2, 14, "2 cups, softened" },
                    { 1, 13, "to taste" },
                    { 1, 12, "1/2 cup shredded" },
                    { 1, 11, "1/4 cup, chopped" },
                    { 1, 10, "2 pinches" },
                    { 1, 9, "1 teaspoon" },
                    { 1, 8, "1 tablespoon" },
                    { 1, 7, "4 oz" },
                    { 1, 6, "15 oz" },
                    { 1, 5, "5 1/4 cups" },
                    { 1, 4, "2 cloves, minced" },
                    { 3, 26, "1/4 teaspoon" },
                    { 3, 27, "2 ounces" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Spaghetti Noodles");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Ketchup");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 1, 1 },
                column: "Action",
                value: "Cook sketti in boiling water.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 1, 2 },
                column: "Action",
                value: "Separate noodles from water with strainer.");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumberID" },
                keyValues: new object[] { 1, 3 },
                column: "Action",
                value: "Put noodles in bowl and add ketchup to preference.");

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 1 },
                column: "Quantity",
                value: "12 ounces");

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "RecipeID", "IngredientsID" },
                keyValues: new object[] { 1, 2 },
                column: "Quantity",
                value: "Personal preference");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Sketti 'n' Ketchup");
        }
    }
}
