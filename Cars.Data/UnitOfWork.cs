using System;
using Cars.Data.Contracts;

namespace Cars.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarsDbContext dbContext;

        public UnitOfWork(CarsDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            this.dbContext = dbContext;
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }
    }
}
