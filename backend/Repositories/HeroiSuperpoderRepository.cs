using backend.Repositories.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class HeroiSuperpoderRepository : IHeroiSuperpoderRepository
    {
        private readonly backendContext _context;

        public HeroiSuperpoderRepository(backendContext ctx)
        {
            _context = ctx;
        }

        public HeroiSuperpoderModel Add(HeroiSuperpoderModel model)
        {
            _context.HeroisSuperpoderes.Add(model);
            _context.SaveChanges();
            return model;
        }

        public List<HeroiSuperpoderModel> Get(int heroiId)
        {
            return _context.HeroisSuperpoderes.Where(hs => hs.HeroiId == heroiId).ToList();
        }

        public bool Delete(int heroiId, int superpoderId)
        {
            var obj = _context.HeroisSuperpoderes.Where(hs => hs.HeroiId == heroiId && hs.SuperpoderId == superpoderId).FirstOrDefault();
            if (obj != null)
            {
                try
                {
                    _context.HeroisSuperpoderes.Remove(obj);
                    _context.SaveChanges();
                }
                catch (System.Exception e)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

