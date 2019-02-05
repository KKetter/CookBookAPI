using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookBookAPI.Models
{
    public class RecipeIngredients
    {
        [Required]
        public int RecipeID { get; set; }
        [Required]
        public int IngredientsID { get; set; }
        [Column(TypeName = "varchar(max)")]
        [MaxLength]
        public string Quantity { get; set; }

        //Navigation Properties
        public Recipes Recipe { get; set; }
        public Ingredients Ingredient { get; set; }
        
    }
}
