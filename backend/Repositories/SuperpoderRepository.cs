using backend.Repositories.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class SuperpoderRepository : ISuperpoderRepository
    {
        private readonly backendContext _context;

        public SuperpoderRepository(backendContext ctx)
        {
            _context = ctx;
        }

        public SuperpoderModel Add(SuperpoderModel model)
        {
            _context.Superpoderes.Add(model);
            _context.SaveChanges();
            return model;
        }

        public List<SuperpoderModel> Get(string token)
        {
            return _context.Superpoderes.Where(h => h.Superpoder.Contains(token) || h.Descricao.Contains(token)).ToList();
        }

    }
}

