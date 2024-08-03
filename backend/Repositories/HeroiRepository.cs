using backend.Repositories.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class HeroiRepository : IHeroiRepository
    {
        private readonly backendContext _context;

        public HeroiRepository(backendContext ctx)
        {
            _context = ctx;
        }

        public HeroiModel Add(HeroiModel model)
        {
            _context.Herois.Add(model);
            _context.SaveChanges();
            return model;
        }

        public HeroiModel Get(int id)
        {
            return _context.Herois.Where(h => h.id == id).FirstOrDefault();
        }

        public HeroiModel GetByNomeHeroi(string nomeHeroi)
        {
            return _context.Herois.Where(h => h.NomeHeroi == nomeHeroi).FirstOrDefault();
        }

        public bool Delete(int id)
        {
            var obj = this.Get(id);
            if (obj != null)
            {
                try
                {
                    _context.Herois.Remove(obj);
                    _context.SaveChanges();
                }
                catch (System.Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        public HeroiModel Update(HeroiModel model)
        {
            _context.Attach(model);
            var entry = _context.Entry(model);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
            return model;
        }

        public IEnumerable<HeroiModel> GetHerois() => _context.Herois;
    }
}

