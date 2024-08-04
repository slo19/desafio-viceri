using backend.Services.Interfaces;
using backend.Models;
using backend.Repositories.Interfaces;

namespace backend.Services
{
    public class SuperpoderService : ISuperpoderService
    {
        private ISuperpoderRepository _repository;

        public SuperpoderService(ISuperpoderRepository repository)
        {
            _repository = repository;
        }

        public List<SuperpoderModel> Get(string token) => _repository.Get(token);

        public List<SuperpoderModel> GetByIds(List<int> ids) => _repository.GetByIds(ids);

        public SuperpoderModel Add(SuperpoderModel model) => _repository.Add(model);

    }
}
