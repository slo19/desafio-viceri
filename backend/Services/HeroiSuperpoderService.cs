using backend.Services.Interfaces;
using backend.Models;
using backend.Repositories.Interfaces;

namespace backend.Services
{
    public class HeroiSuperpoderService : IHeroiSuperpoderService
    {
        private IHeroiSuperpoderRepository _repository;

        public HeroiSuperpoderService(IHeroiSuperpoderRepository repository)
        {
            _repository = repository;
        }

        public List<HeroiSuperpoderModel> Get(int heroiId) => _repository.Get(heroiId);

        public HeroiSuperpoderModel Add(HeroiSuperpoderModel model) => _repository.Add(model);

        public bool Delete(int heroiId, int superpoderId) => _repository.Delete(heroiId, superpoderId);
    }
}
