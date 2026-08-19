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
            var frutas = await _context.Frutas.ToListAsync();

            return Ok(frutas);
        }
    }
}
