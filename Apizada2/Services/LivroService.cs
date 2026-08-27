using Apizada2.Models;
using Apizada2.Respositories;

namespace Apizada2.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;
        public LivroService(ILivroRepository repository) 
        {
            _repository = repository;
        }

        public async Task<bool> AtualizarAync(int id, Livro livro)
        {
            var existe  = await _repository.ObterPorIdAsync(id);
            if(existe is null) return false;

            existe.Titulo = livro.Titulo;
            existe.Autor = livro.Autor;
            existe.Preco = livro.Preco;
            existe.AnoPublicacao = livro.AnoPublicacao;

            await _repository.AtualizarAsync(existe);
            return true;
         }

        public async Task<Livro> CriarAsync(Livro livro)
        {
            await _repository.AdicionarLivro(livro);
            return livro;
        }

        public Task<List<Livro>> ListarAsync()
        {
          return _repository.ObterTodosAsync();
        }

        public Task<Livro?> ObterPorIdAsync(int id)
        {
            return _repository.ObterPorIdAsync(id);
        }

       public async Task<bool> RemoverAsync(int id)
        {
            var livro = await _repository.ObterPorIdAsync(id);
            if (livro is null) return false;

           await _repository.RemoverAsync(livro);
            return true;

        }
    }
}
