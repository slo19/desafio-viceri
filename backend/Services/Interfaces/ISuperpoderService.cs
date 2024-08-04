using backend.Models;

namespace backend.Services.Interfaces
{
    public interface ISuperpoderService
    {
        public List<SuperpoderModel> Get(string token);
        public List<SuperpoderModel> GetByIds(List<int> ids);
        public SuperpoderModel Add(SuperpoderModel model);
    }
}
