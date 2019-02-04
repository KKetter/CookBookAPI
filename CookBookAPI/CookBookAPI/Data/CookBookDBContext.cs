﻿using CookBookAPI.Models;
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

        DbSet<RecipieIngredients> RecipieIngredients { get; set; }
        DbSet<Ingredients> Ingredients { get; set; }
        DbSet<Recipes> Recipes { get; set; }
        DbSet<Instructions> Instructions { get; set; }
    }
}
