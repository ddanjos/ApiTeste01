using Apizada2.Infraestructure;
using Apizada2.Models;
using Microsoft.EntityFrameworkCore;

namespace Apizada2.Respositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly AppDbContext _context;

        public LivroRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AdicionarLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Livro livro)
        {
           _context.Livros.Update(livro);
            await _context.SaveChangesAsync();
        }

        public async Task<Livro?> ObterPorIdAsync(int id)
        {
            return await _context.Livros.FindAsync(id);
        }

        public async Task<List<Livro>> ObterTodosAsync()
        {
            return await _context.Livros.ToListAsync();
        }

        public async Task RemoverAsync(Livro livro)
        {
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync(true);
        }
    }
}
