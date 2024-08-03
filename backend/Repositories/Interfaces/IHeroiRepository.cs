using backend.Models;

namespace backend.Repositories.Interfaces
{
    public interface IHeroiRepository
    {
        public HeroiModel Add(HeroiModel model);
        public HeroiModel Get(int id);
        public HeroiModel GetByNomeHeroi(string nomeHeroi);
        public HeroiModel Update(HeroiModel model);
        public bool Delete(int id);
        public IEnumerable<HeroiModel> GetHerois();
    }
}
