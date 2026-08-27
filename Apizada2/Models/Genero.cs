using System.Text.Json.Serialization;

namespace Api02.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        [JsonIgnore]
        public List<Livro> livros { get; set; } = new();

        public static implicit operator Genero(Task<Genero?> v)
        {
            throw new NotImplementedException();
        }
    }
}
