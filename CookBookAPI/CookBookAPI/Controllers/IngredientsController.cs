using CookBookAPI.Data;
using CookBookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CookBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly CookBookDbContext _context;
        private readonly IConfiguration Configuration;

        public IngredientsController(CookBookDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        // GET
        /// <summary>
        /// Returns a collection of all ingredients
        /// </summary>
        /// <returns>List of ingredients</returns>
        [HttpGet]
        public IEnumerable<Ingredients> Get()
        {
            return _context.Ingredients;
        }

        /// <summary>
        /// Returns a specific ingredient requested by ID
        /// </summary>
        /// <param name="id">Primary Key value</param>
        /// <returns>Matching ingredient if found</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Ingredients ingredient = _context.Ingredients.FirstOrDefault(i => i.ID == id);
            if (ingredient == null)
            {
                return NotFound();
            }

            return Ok(ingredient);
        }

        // POST
        /// <summary>
        /// Adds a new ingredient entry to the table
        /// </summary>
        /// <param name="ingredient">New ingredient object</param>
        /// <returns>New ingredient</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Ingredients ingredient)
        {
            if (ingredient != null)
            {
                await _context.Ingredients.AddAsync(ingredient);
                await _context.SaveChangesAsync();

                return RedirectToAction("Get", new { ingredient.ID });
            }

            return NotFound();
        }

        // PUT
        /// <summary>
        /// Updates an existing ingredient entry or adds it if it doesn't exist
        /// </summary>
        /// <param name="id">Primary Key value</param>
        /// <param name="ingredient">Ingredient object with edited data</param>
        /// <returns>Edited or new ingredient</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody]Ingredients ingredient)
        {
            if (ingredient.ID != id)
            {
                return BadRequest(ModelState);
            }

            Ingredients result = _context.Ingredients.FirstOrDefault(i => i.ID == id);
            if (result == null)
            {
                return RedirectToAction("Post", ingredient);
            }

            result.Name = ingredient.Name;

            _context.Update(result);
            await _context.SaveChangesAsync();
            return Ok("Successful update");
        }

        // DELETE
        /// <summary>
        /// Selects a specific ingredient for deletion if it exists
        /// </summary>
        /// <param name="id">Primary Key value</param>
        /// <returns>Successful response or not found</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var ingredient = _context.Ingredients.FirstOrDefault(i => i.ID == id);

            if (ingredient == null)
            {
                return NotFound();
            }

            _context.Ingredients.Remove(ingredient);
            await _context.SaveChangesAsync();
            return Ok("Successful deletion");
        }
    }
}