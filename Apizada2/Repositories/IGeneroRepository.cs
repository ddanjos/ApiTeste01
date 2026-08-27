using Api02.Models;

namespace Api02.Repositories
{
    public interface IGeneroRepository
    {
        Task<List<Genero>> ObterTodosAsync();
        Task<Genero?> ObterPorIdAsync(int id);
        Task AdicionarAsync(Genero genero);
        Task AtualizarAsync(Genero genero);
        Task RemoverAsync(Genero genero);

    }
}
