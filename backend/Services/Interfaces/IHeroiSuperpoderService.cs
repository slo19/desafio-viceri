using backend.Models;

namespace backend.Services.Interfaces
{
    public interface IHeroiSuperpoderService
    {
        public List<HeroiSuperpoderModel> Get(int heroiId);
        public HeroiSuperpoderModel Add(HeroiSuperpoderModel model);
        public bool Delete(int heroiId, int superpoderId);
    }
}
