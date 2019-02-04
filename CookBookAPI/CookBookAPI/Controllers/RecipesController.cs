using CookBookAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CookBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly CookBookDbContext _context;

        public RecipesController(CookBookDbContext context)
        {
            _context = context;
        }

        // GET

        // POST

        // PUT

        // DELETE
    }
}