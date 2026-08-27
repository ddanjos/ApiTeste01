using Api02.Models;

namespace Api02.Respositories
{
    public interface IGeneroRepository
    {
        Task<List<Genero>> ObterTodosAsync();
        Task<Genero?> ObterPorIdAsync(int id);
        Task<List<Genero>> ObterPorNomeAsync(string nome);

    }
}
