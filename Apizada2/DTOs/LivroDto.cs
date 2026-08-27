namespace Api02.DTOs
{
    public class LivroDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public decimal Preco { get; set; }
        public int GeneroId { get; set; }
    }
}
