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
            modelBuilder.Entity<RecipeIngredients>().HasKey(hr => new { hr.RecipeID, hr.IngredientsID, });

            modelBuilder.Entity<Instructions>().HasKey(hr => new { hr.RecipeID, hr.StepNumberID, });

        }

        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Instructions> Instructions { get; set; }
    }
}
