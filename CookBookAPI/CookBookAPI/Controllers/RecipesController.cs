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
    public class RecipesController : ControllerBase
    {
        private readonly CookBookDbContext _context;
        private readonly IConfiguration Configuration;

        public RecipesController(CookBookDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        // GET
        /// <summary>
        /// Returns a collection of recipes for a given recipe
        /// </summary>
        /// <returns>List of recipes</returns>
        [HttpGet]
        public IEnumerable<Recipes> Get()
        {
            return _context.Recipes;
        }

        /// <summary>
        /// Returns a specific recipe requested by ID
        /// </summary>
        /// <param name="id">Primary Key value</param>
        /// <returns>Matching Recipes object if found</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Recipes recipe = _context.Recipes.FirstOrDefault(i => i.ID == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }

        // POST
        /// <summary>
        /// Adds a new Recipes entry to the table 
        /// </summary>
        /// <param name="recipe">New Recipes object</param>
        /// <returns>New Recipes</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Recipes recipe)
        {
            if (recipe != null)
            {
                await _context.Recipes.AddAsync(recipe);
                await _context.SaveChangesAsync();

                return RedirectToAction("Get", new { recipe.ID });
            }

            return NotFound();
        }

        // PUT
        /// <summary>
        /// Updates an existing Recipes entry or adds it if it doesn't exist
        /// </summary>
        /// <param name="id">Primary Key value</param>
        /// <param name="recipe">Recipes object with edited data</param>
        /// <returns>Edited or new recipe</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody]Recipes recipe)
        {
            if (recipe.ID != id)
            {
                return BadRequest(ModelState);
            }

            Recipes result = _context.Recipes.FirstOrDefault(i => i.ID == id);
            if (result == null)
            {
                return RedirectToAction("Post", recipe);
            }

            result.Name = recipe.Name;

            _context.Update(result);
            await _context.SaveChangesAsync();
            return Ok("Successful update");
        }

        // DELETE
        /// <summary>
        /// Selects a specific recipe for deletion if it exists
        /// </summary>
        /// <param name="id">Primary Key value</param>
        /// <returns>Successful response or not found</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(i => i.ID == id);

            if (recipe == null)
            {
                return NotFound();
            }

            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
            return Ok("Successful deletion");
        }
    }
}