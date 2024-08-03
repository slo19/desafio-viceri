using backend.Models;

namespace backend.Services.Interfaces
{
    public interface IHeroiService
    {
        public List<HeroiModel> GetHerois();
        public HeroiModel Add(HeroiModel model);
    }
}
