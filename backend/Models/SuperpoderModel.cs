using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class SuperpoderModel
    {
        public int id { get; set; }
        public string Superpoder { get; set; } = "";
        public string? Descricao { get; set; }
    }
}
