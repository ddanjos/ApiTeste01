using Api02.Models;
using Api02.Services;
using Microsoft.AspNetCore.Mvc;


namespace Api02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroService _service;

        public GeneroController(IGeneroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Genero>>> Listar()
        {
            return Ok(await _service.ListarAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Genero>> BuscarPorId(int id)
        {
            var Genero = await _service.ObterPorIdAsync(id);
            return Genero is null ? NotFound() : Ok(Genero);
        }
        [HttpPost]
        public async Task<ActionResult<Genero>> Criar(Genero Genero)
        {
            var criado = await _service.CriarAsync(Genero);
            return CreatedAtAction(nameof(BuscarPorId), new {id = criado.Id}, criado);
        }
       




    }
}
