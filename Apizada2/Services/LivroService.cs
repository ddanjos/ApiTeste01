using Api02.DTOs;
using Api02.Models;
using Api02.Repositories;

namespace Api02.Services
{
    public class LivroService : ILivroService
    {

        private readonly ILivroRepository _repository;
        private readonly IGeneroService _generoService;

        public LivroService(ILivroRepository repository, IGeneroService generoService)
        {
            _repository = repository;
            _generoService = generoService;
        }

        public async Task<bool> AtualizarAsync(int id, Livro livro)
        {
            var existente = await _repository.ObterPorIdAsync(id);
            if (existente is null) return false;

            existente.Titulo = livro.Titulo;
            existente.Autor = livro.Autor;
            existente.AnoPublicacao = livro.AnoPublicacao;
            existente.Preco = livro.Preco;
            await _repository.AtualizarAsync(existente);
            return true;
        }

        public async Task<Livro> CriarAsync(LivroDto dto)
        {
            var genero = _generoService.ObterPorIdAsync(dto.GeneroId);
            if (genero is null) return null;

            Livro livro = new Livro();
            livro.Autor = dto.Autor;
            livro.Titulo = dto.Titulo;
            livro.AnoPublicacao = dto.AnoPublicacao;
            livro.Id = dto.Id;
            livro.GeneroId = genero.Id;

            await _repository.AdicionarAsync(livro);
            return livro;
        }

        public Task<List<Livro>> ListarAsync(string? autor = null)
        {
           return string.IsNullOrWhiteSpace(autor) 
                ? _repository.ObterTodosAsync()
                : _repository.ObterPorAutorAsync(autor);
        }

        public Task<Livro?> ObterPorIdAsync(int id)
        {
            return _repository.ObterPorIdAsync(id);
        }

        public async Task<bool> RemoverAsync(int id)
        {
            var livro = await _repository.ObterPorIdAsync(id);
            if(livro is null) return false;

            await _repository.RemoverAsync(livro);
            return true;
        }
    }
}
