using System;
using System.Linq;
using Cars.Data.Contracts;

namespace Cars.Data
{
    public class Repository<T> : IRepository<T>
        where T: class
    {
        private readonly CarsDbContext dbContext;

        public Repository(CarsDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            this.dbContext = dbContext;
        }

        public IQueryable<T> All
        {
            get
            {
                return this.dbContext.DbSet<T>();
            }
        }
    }
}
