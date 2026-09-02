using AulaBackend_API.Data;
using AulaBackend_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaBackend_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            var produtos = await _context.Produto.ToListAsync();

            return Ok(produtos);
        }

        // GET: api/Produto/1
        // Consultar um produto pelo ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await _context.Produto.FindAsync(id);

            if (produto == null)
            {
                return NotFound(new
                {
                    mensagem = "Produto não encontrado."
                });
            }

            return Ok(produto);
        }

        // POST: api/Produto
        // Cadastrar produto
        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            _context.Produto.Add(produto);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetProduto),
                new { id = produto.Id },
                produto
            );
        }

        // PUT: api/Produto/1
        // Alterar produto
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest(new
                {
                    mensagem = "O ID da URL é diferente do ID do produto."
                });
            }

            var produtoExistente = await _context.Produto.FindAsync(id);

            if (produtoExistente == null)
            {
                return NotFound(new
                {
                    mensagem = "Produto não encontrado."
                });
            }

            produtoExistente.Nome = produto.Nome;
            produtoExistente.Descricao = produto.Descricao;
            produtoExistente.Preco = produto.Preco;
            produtoExistente.Estoque = produto.Estoque;
            produtoExistente.Ativo = produto.Ativo;

            await _context.SaveChangesAsync();

            return Ok(produtoExistente);
        }

        // DELETE: api/Produto/1
        // Excluir produto
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var produto = await _context.Produto.FindAsync(id);

            if (produto == null)
            {
                return NotFound(new
                {
                    mensagem = "Produto não encontrado."
                });
            }

            _context.Produto.Remove(produto);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                mensagem = "Produto excluído com sucesso."
            });
        }
    }
}
