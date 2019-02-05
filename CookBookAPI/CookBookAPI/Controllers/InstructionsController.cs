using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBookAPI.Data;
using CookBookAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CookBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionsController : ControllerBase
    {
        private readonly CookBookDbContext _context;
        private readonly IConfiguration Configuration;

        public InstructionsController(CookBookDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        // GET
        /// <summary>
        /// Returns a collection of instructions for a given recipe
        /// </summary>
        /// <returns>List of recipe instructions</returns>
        [HttpGet]
        public IEnumerable<Instructions> Get()
        {
            return _context.Instructions;
        }

        /// <summary>
        /// Returns a specific recipe instructions requested by recipe ID
        /// </summary>
        /// <param name="id">RecipeID property</param>
        /// <returns>Matching instructions object if found</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Instructions instruction = _context.Instructions.FirstOrDefault(i => i.RecipeID == id);
            if (instruction == null)
            {
                return NotFound();
            }

            return Ok(instruction);
        }

        // POST
        /// <summary>
        /// Adds a new instructions entry to the table 
        /// </summary>
        /// <param name="instruction">New instructions object</param>
        /// <returns>New instructions</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Instructions instruction)
        {
            if (instruction != null)
            {
                await _context.Instructions.AddAsync(instruction);
                await _context.SaveChangesAsync();

                return RedirectToAction("Get", new { instruction.RecipeID });
            }

            return NotFound();
        }

        // PUT
        /// <summary>
        /// Updates an existing recipe instructions entry or adds it if it doesn't exist
        /// </summary>
        /// <param name="id">RecipeID property</param>
        /// <param name="instruction">Instructions object with edited data</param>
        /// <returns>Edited or new recipe instructions</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody]Instructions instruction)
        {
            if (instruction.RecipeID != id)
            {
                return BadRequest(ModelState);
            }

            Instructions result = _context.Instructions.FirstOrDefault(i => i.RecipeID == id);
            if (result == null)
            {
                return RedirectToAction("Post", instruction);
            }

            result.RecipeID = instruction.RecipeID;
            result.StepNumberID = instruction.StepNumberID;
            result.Action = instruction.Action;

            _context.Update(result);
            await _context.SaveChangesAsync();
            return Ok("Successful update");
        }

        // DELETE
        /// <summary>
        /// Selects a specific instruction for deletion if it exists
        /// </summary>
        /// <param name="id">RecipeID property</param>
        /// <returns>Successful response or not found</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var instruction = _context.Instructions.FirstOrDefault(i => i.RecipeID == id);

            if (instruction == null)
            {
                return NotFound();
            }

            _context.Instructions.Remove(instruction);
            await _context.SaveChangesAsync();
            return Ok("Successful deletion");
        }
    }
}