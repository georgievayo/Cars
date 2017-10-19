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

        public T GetById(object id)
        {
            return this.dbContext.DbSet<T>().Find(id);
        }

        public IQueryable<T> All
        {
            get
            {
                return this.dbContext.DbSet<T>();
            }
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
