using backend.Models;

namespace backend.DTOs
{
    public class PerfilDTO
    {
        public HeroiModel Heroi { get; set; }
        public List<SuperpoderModel> Superpoderes { get; set; }
    }
}
