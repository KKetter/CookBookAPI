using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBookAPI.Data;
using CookBookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CookBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeIngredientsController : ControllerBase
    {
        private readonly CookBookDbContext _context;
        private readonly IConfiguration Configuration;

        public RecipeIngredientsController(CookBookDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        // GET
        /// <summary>
        /// Returns a collection of all recipe ingredients.
        /// </summary>
        /// <returns>List of recipe ingredients</returns>
        [HttpGet]
        public IEnumerable<RecipeIngredients> Get()
        {
            return _context.RecipeIngredients;
        }

        /// <summary>
        /// Returns a specific recipe ingredient requested by recipe ID and ingredient ID
        /// </summary>
        /// <param name="recID">RecipeID property</param>
        /// <param name="ingID">IngredientID property</param>
        /// <returns>Matching recipe ingredient if found</returns>
        [HttpGet("{recID}/{ingID}")]
        public IActionResult Get([FromRoute] int recID, [FromRoute] int ingID)
        {
            RecipeIngredients RecIng = _context.RecipeIngredients
                .FirstOrDefault(i => i.RecipeID == recID && i.IngredientsID == ingID);

            if (RecIng == null)
            {
                return NotFound();
            }

            return Ok(RecIng);
        }

        // POST
        /// <summary>
        /// Adds a new recipe ingredient entry to the table
        /// </summary>
        /// <param name="recIng">New recipe ingredient object</param>
        /// <returns>New recipe ingredient</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RecipeIngredients recIng)
        {
            if (recIng != null)
            {
                await _context.RecipeIngredients.AddAsync(recIng);
                await _context.SaveChangesAsync();

                return RedirectToAction("Get", new { recIng.RecipeID, recIng.IngredientsID });
            }

            return NotFound();
        }

        // PUT
        /// <summary>
        /// Updates an existing recipe ingredient entry in the table, or adds it if it doesn't exist.
        /// </summary>
        /// <param name="recID">RecipeID property</param>
        /// <param name="ingID">IngredientID property</param>
        /// <param name="recIng">Recipe ingredient object with edited data</param>
        /// <returns>Updated or new recipe ingredient</returns>
        [HttpPut("{recID}/{ingID}")]
        public async Task<IActionResult> Put([FromRoute] int recID, [FromRoute] int ingID, [FromBody]RecipeIngredients recIng)
        {
            if (recIng.RecipeID != recID || recIng.IngredientsID != ingID)
            {
                return BadRequest(ModelState);
            }

            RecipeIngredients result = _context.RecipeIngredients.FirstOrDefault(i => i.RecipeID == recID && i.IngredientsID == ingID);
            if (result == null)
            {
                return RedirectToAction("Post", recIng);
            }

            result.RecipeID = recIng.RecipeID;
            result.IngredientsID = recIng.IngredientsID;
            result.Quantity = recIng.Quantity;

            _context.Update(result);
            await _context.SaveChangesAsync();
            return Ok("Successful update");
        }

        // DELETE
        /// <summary>
        /// Selects a specific recipe ingredient for deletion if it exists
        /// </summary>
        /// <param name="recID">RecipeID property</param>
        /// <param name="ingID">IngredientID property</param>
        /// <returns>Successful response or not found</returns>
        [HttpDelete("{recID}/{ingID}")]
        public async Task<IActionResult> Delete([FromRoute] int recID, [FromRoute] int ingID)
        {
            var recIng = _context.RecipeIngredients
                .FirstOrDefault(i => i.RecipeID == recID && i.IngredientsID == ingID);

            if (recIng == null)
            {
                return NotFound();
            }

            _context.RecipeIngredients.Remove(recIng);
            await _context.SaveChangesAsync();
            return Ok("Successful deletion");
        }
    }
}