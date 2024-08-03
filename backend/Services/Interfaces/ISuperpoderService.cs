using backend.Models;

namespace backend.Services.Interfaces
{
    public interface ISuperpoderService
    {
        public List<SuperpoderModel> Get(string token);
        public SuperpoderModel Add(SuperpoderModel model);
    }
}
