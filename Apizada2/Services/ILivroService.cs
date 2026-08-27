using Api02.DTOs;
using Api02.Models;

namespace Api02.Services
{
    public interface ILivroService
    {
        Task<List<Livro>> ListarAsync(string? autor = null);
        Task<Livro?> ObterPorIdAsync(int id);
        Task<Livro> CriarAsync(LivroDto livro);
        Task<bool> AtualizarAsync(int id, Livro livro);
        Task<bool> RemoverAsync(int id);
    }
}
