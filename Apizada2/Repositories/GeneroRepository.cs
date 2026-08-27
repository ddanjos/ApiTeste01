using Api02.Infra;
using Api02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api02.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {

        private readonly AppDbContext _context;

        public GeneroRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Genero genero)
        {
            _context.Generos.Add(genero);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Genero genero)
        {
            _context.Generos.Update(genero);
            await _context.SaveChangesAsync();
        }

        // select * form Genero where autor like "%martin%"
    

        public async Task<Genero?> ObterPorIdAsync(int id)
        {
            return await _context.Generos.FindAsync(id);
        }

        public async Task<List<Genero>> ObterTodosAsync()
        {
            return await _context.Generos.ToListAsync();
        }

        public async Task RemoverAsync(Genero genero)
        {
            _context.Generos.Remove(genero);
            await _context.SaveChangesAsync();
        }
    }
}
