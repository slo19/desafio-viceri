using backend.Models;

namespace backend.Repositories.Interfaces
{
    public interface ISuperpoderRepository
    {
        public SuperpoderModel Add(SuperpoderModel model);
        public List<SuperpoderModel> Get(string token);
    }
}
