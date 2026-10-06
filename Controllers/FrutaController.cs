using AulaBackend_API.Data;
using AulaBackend_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaBackend_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FrutaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FrutaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fruta>>> Get()
        {
            var frutas = await _context.Fruta.ToListAsync();

            return Ok(frutas);
        }

        [HttpPost]
        public async Task<ActionResult<Fruta>> PostFruta(Fruta fruta)
        {
            _context.Fruta.Add(fruta);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(Get),
                new { id = fruta.id },
                fruta
            );
        }
    }
}
