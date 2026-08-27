namespace Apizada2.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public DateTime AnoPublicacao { get; set; }

        public decimal Preco { get; set; }
    }
}
