using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookBookAPI.Models
{
    public class Ingredients
    {
        public int ID { get; set;}
        public string Name { get; set; }

        //Navigation Properties
        public ICollection<RecipeIngredients> Recipe { get; set; }
    }
}
