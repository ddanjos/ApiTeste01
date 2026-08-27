using Api02.Models;

namespace Api02.Repositories
{
    public interface ILivroRepository
    {
        Task<List<Livro>> ObterTodosAsync();
        Task<Livro?> ObterPorIdAsync(int id);
        Task AdicionarAsync(Livro livro);
        Task AtualizarAsync(Livro livro);
        Task RemoverAsync(Livro livro);
        Task<List<Livro>> ObterPorAutorAsync(string autor);

    }
}
