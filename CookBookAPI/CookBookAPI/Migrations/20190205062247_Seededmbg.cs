using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CookBookAPI.Migrations
{
    public partial class Seededmbg : Migration
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
                    Name = table.Column<string>(nullable: true)
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
                values: new object[] { 1, "Spaghetti Noodles" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Ketchup" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Sketti 'n' Ketchup" });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "RecipeID", "StepNumberID", "Action" },
                values: new object[,]
                {
                    { 1, 1, "Cook sketti in boiling water." },
                    { 1, 2, "Separate noodles from water with strainer." },
                    { 1, 3, "Put noodles in bowl and add ketchup to preference." }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "RecipeID", "IngredientsID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "12 ounces" },
                    { 1, 2, "Personal preference" }
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
