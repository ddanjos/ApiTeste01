using Api02.Models;
using Api02.Repositories;

namespace Api02.Services
{
    public class GeneroService : IGeneroService
    {

        private readonly IGeneroRepository _repository;

        public GeneroService(IGeneroRepository repository)
        {
            this._repository = repository;
        }

      

        public async Task<Genero> CriarAsync(Genero Genero)
        {
            await _repository.AdicionarAsync(Genero);
            return Genero;
        }

        public Task<List<Genero>> ListarAsync()
        {
            return _repository.ObterTodosAsync();
              
        }

        public Task<Genero?> ObterPorIdAsync(int id)
        {
            return _repository.ObterPorIdAsync(id);
        }

       
    }
}
