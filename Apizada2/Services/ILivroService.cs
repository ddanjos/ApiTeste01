using Apizada2.Models;

namespace Apizada2.Services
{
    public interface ILivroService
    {
        Task<List<Livro>> ListarAsync();

        Task<Livro?> ObterPorIdAsync(int id);

        Task<Livro> CriarAsync(Livro livro);

        Task<bool> AtualizarAync(int id, Livro livro);

        Task<bool> RemoverAsync(int id);
    }
}
