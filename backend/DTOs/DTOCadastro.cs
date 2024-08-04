using backend.Models;

namespace backend.DTOs
{
    public class CadastroHeroiDTO
    {
        public HeroiModel Heroi { get; set; }
        public List<int> SuperpoderesIds { get; set; }
    }
}
