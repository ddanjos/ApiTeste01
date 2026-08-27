using Api02.Models;
using Microsoft.EntityFrameworkCore;

namespace Api02.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Livro> Livros => Set<Livro>();
        public DbSet<Genero> Generos => Set<Genero>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Genero)
                .WithMany(g => g.livros)
                .HasForeignKey(l => l.GeneroId)
                .OnDelete(DeleteBehavior.Restrict);
        }



      
    }
}
