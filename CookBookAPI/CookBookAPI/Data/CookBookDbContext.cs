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

        DbSet<RecipeIngredients> RecipeIngredients { get; set; }
    }
}
