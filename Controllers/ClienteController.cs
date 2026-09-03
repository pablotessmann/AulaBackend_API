using AulaBackend_API.Data;
using AulaBackend_API.DTOs;
using AulaBackend_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaBackend_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            var clientes = await _context.Cliente.ToListAsync();

            return Ok(clientes);
        }

        // POST: api/Cliente
        // Cadastrar cliente
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostProduto(ClienteRequest request)
        {
            // Remove tudo que não for número
            string cpfLimpo = new string(
                request.Cpf.Where(char.IsDigit).ToArray()
            );
            // Converte para inteiro
            int cpf = int.Parse(cpfLimpo);
            var cliente = new Cliente
            {
                Nome = request.Nome,
                Email = request.Email,
                Telefone = request.Telefone,
                Cpf = cpf,
                Endereco = request.Endereco,
                Cidade = request.Cidade,
                Estado = request.Estado,
            };

            _context.Produto.Add(cliente);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetProduto),
                new { id = produto.Id },
                produto
            );
        }
    }
}
