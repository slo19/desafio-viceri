using backend.Models;

namespace backend.Repositories.Interfaces
{
    public interface ISuperpoderRepository
    {
        public SuperpoderModel Add(SuperpoderModel model);
        public List<SuperpoderModel> Get(string token);
        public List<SuperpoderModel> GetByIds(List<int> ids);
    }
}
