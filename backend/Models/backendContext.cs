using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class backendContext : DbContext
    {

        public backendContext(DbContextOptions<backendContext> options) : base(options)
        {

        }

        public DbSet<HeroiModel> Herois => Set<HeroiModel>();
        public DbSet<SuperpoderModel> Superpoderes => Set<SuperpoderModel>();
        public DbSet<HeroiSuperpoderModel> HeroisSuperpoderes => Set<HeroiSuperpoderModel>();
    }
}
