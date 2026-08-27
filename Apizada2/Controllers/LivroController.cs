using Apizada2.Models;
using Apizada2.Services;
using Microsoft.AspNetCore.Mvc;


namespace Apizada2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LivroController : ControllerBase
    {
        private readonly ILivroService _service;

        public LivroController(ILivroService livro)
        {
            _service = livro;
        }

        [HttpGet]
        public async Task<ActionResult<List<Livro>>> Listar([FromQuery] string? autor)
        {
            return Ok(await _service.ListarAsync(autor));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Livro>> BuscarPorId(int id)
        {
            var livro = await _service.ObterPorIdAsync(id);
            return livro is null ? NotFound() : Ok(livro);
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> Criar(Livro livro)

        {
            var criado = await _service.CriarAsync(livro);
            return CreatedAtAction(nameof(BuscarPorId), new { id = criado.Id }, criado);

        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Atualizar(int id, Livro livro)
        {
            var ok = await _service.AtualizarAync(id, livro);
            return ok ? NoContent() : NotFound();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remover(int id)
        {
            var ok = await _service.RemoverAsync(id);
            return ok ? NoContent() : NotFound();
        }
    }
}