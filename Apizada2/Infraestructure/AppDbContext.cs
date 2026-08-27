using Apizada2.Models;
using Microsoft.EntityFrameworkCore;

namespace Apizada2.Infraestructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Livro> Livros => Set<Livro>();
    }
}