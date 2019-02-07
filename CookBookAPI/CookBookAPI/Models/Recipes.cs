﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookAPI.Models
{
    public class Recipes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        // Navigation
        public ICollection<Instructions> InstructionID { get; set; }
        public ICollection<RecipeIngredients> IngredientID { get; set; }
    }
}
