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

        public List<HeroiModel> GetHerois()
        {
            return _repository.GetHerois().ToList();
        }

        public HeroiModel Add(HeroiModel model)
        {
            var returnModel = _repository.Add(model);
            return returnModel;
        }
    }
}
