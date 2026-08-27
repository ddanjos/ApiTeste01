using Api02.Infraestructure;
using Api02.Models;
using Microsoft.EntityFrameworkCore;

namespace Api02.Respositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly AppDbContext _context;
        public GeneroRepository(AppDbContext appDbContext) 
        {
            _context = appDbContext;
        }

        public async Task<Genero?> ObterPorIdAsync(int id)
        {
            return await _context.Generos.FindAsync(id);
        }

        public async Task<List<Genero>> ObterTodosAsync()
        {
            return await _context.Generos.ToListAsync();

        }

        public async Task<List<Genero>> ObterPorNomeAsync(string nome)
        {
            return await _context.Generos.
                Where(g => EF.Functions.ILike(g.Nome, $"%{nome}%")).
                ToListAsync();
        }
    }
}
