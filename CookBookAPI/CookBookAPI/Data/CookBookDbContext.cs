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
                    Name = "Sketti 'n' Ketchup",
                }
            );

            modelBuilder.Entity<Ingredients>().HasData(
                new Ingredients()
                {
                    ID = 1,
                    Name = "Spaghetti Noodles",
                },
                new Ingredients()
                {
                    ID = 2,
                    Name = "Ketchup",
                }
            );

            modelBuilder.Entity<RecipeIngredients>().HasData(
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 1,
                    Quantity = "12 ounces"
                },
                new RecipeIngredients()
                {
                    RecipeID = 1,
                    IngredientsID = 2,
                    Quantity = "Personal preference"
                }
            );

            modelBuilder.Entity<Instructions>().HasData(
                new Instructions()
                {
                    RecipeID = 1,
                    StepNumberID = 1,
                    Action = "Cook sketti in boiling water."
                },
                new Instructions()
                {
                    RecipeID = 1,
                    StepNumberID = 2,
                    Action = "Separate noodles from water with strainer."
                },
                new Instructions()
                {
                    RecipeID = 1,
                    StepNumberID = 3,
                    Action = "Put noodles in bowl and add ketchup to preference."
                }
            );
        }

        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Instructions> Instructions { get; set; }
    }
}
