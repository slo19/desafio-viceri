using backend.Models;

namespace backend.Repositories.Interfaces
{
    public interface IHeroiSuperpoderRepository
    {
        public HeroiSuperpoderModel Add(HeroiSuperpoderModel model);
        public List<HeroiSuperpoderModel> Get(int heroiId);
        public bool Delete(int heroiId, int superpoderId);
    }
}
