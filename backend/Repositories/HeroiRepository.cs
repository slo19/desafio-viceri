using backend.Repositories.Interfaces;
using backend.Models;

namespace backend.Repositories
{
    public class HeroiRepository : IHeroiRepository
    {
        private readonly backendContext _context;

        public EventoRepository(backendContext ctx)
        {
            _context = ctx;
        }

        public HeroiModel Add(HeroiModel model)
        {
            _context.Herois.Add(model);
            _context.SaveChanges();
            return _context.Herois.Where(h => h.Nome == model.Nome).First();
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
            var obj = _context.Herois.Where(h => h.id == model.id).FirstOrDefault();
            if (obj != null)
            {
                obj = model;
                _context.SaveChanges();
                return model;
            }
            return null;

        }

        public IEnumerable<HeroiModel> GetHerois() => _context.Herois;
    }
}

