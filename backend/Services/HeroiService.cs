using backend.Services.Interfaces;
using backend.Models;
using backend.Repositories.Interfaces;

namespace backend.Services
{
    public class HeroiService : IHeroiService
    {
        private IHeroiRepository _repository;

        public HeroiService(IHeroiRepository repository)
        {
            _repository = repository;
        }

        public List<HeroiModel> GetHerois() => _repository.GetHerois().ToList();

        public HeroiModel Get(int id) => _repository.Get(id);

        public HeroiModel Add(HeroiModel model) => _repository.Add(model);

        public bool Delete(int id) => _repository.Delete(id);

        public HeroiModel Update(HeroiModel model) => _repository.Update(model);
    }
}
