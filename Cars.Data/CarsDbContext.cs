using System.Data.Entity;
using Cars.Models;

namespace Cars.Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext()
            : base("CarsDb")
        {
            Database.SetInitializer<CarsDbContext>(null);
        }

        public static CarsDbContext Create()
        {
            return new CarsDbContext();
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarModel> CarModels { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public IDbSet<TEntity> DbSet<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }

    }
}
