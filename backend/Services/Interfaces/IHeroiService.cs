using backend.Models;

namespace backend.Services.Interfaces
{
    public interface IHeroiService
    {
        public List<HeroiModel> GetHerois();
        public HeroiModel GetByNomeHeroi(string nomeHeroi);
        public HeroiModel Get(int id);
        public HeroiModel Add(HeroiModel model);
        public bool Delete(int id);
        public HeroiModel Update(HeroiModel model);
    }
}
