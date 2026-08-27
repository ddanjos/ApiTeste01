using Apizada2.Models;

namespace Apizada2.Respositories
{
    public interface ILivroRepository
    {
        Task<List<Livro>> ObterTodosAsync();
        Task<Livro?> ObterPorIdAsync(int id);

        Task AdicionarLivro(Livro livro);

        Task AtualizarAsync(Livro livro);

        Task RemoverAsync(Livro livro);

        Task<List<Livro>> ObterPorAutorAsync(string autor);
    }
}
