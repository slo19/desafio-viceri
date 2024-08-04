using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class HeroiModel
    {
        //[Key]
        public int? id { get; set; }
        public string Nome { get; set; } = "";
        public string NomeHeroi { get; set; } = "";
        public DateTime? DataNascimento { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
    }
}
