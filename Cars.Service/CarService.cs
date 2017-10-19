using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Cars.Models;
using Cars.Service.Contracts;
using Cars.Data.Contracts;

namespace Cars.Service
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> repository;
        private readonly IUnitOfWork unitOfWork;

        public CarService(IRepository<Car> repository, IUnitOfWork unitOfWork)
        {
            if (repository == null)
            {
                throw new ArgumentNullException(nameof(repository));
            }

            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }

            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public ICollection<Car> GetCarsByOwnerId(int? ownerId)
        {
            return this.repository
                .All
                .Include(c => c.Model)
                .Include(c => c.Owner)
                .Where(c => c.OwnerId == ownerId)
                .ToList();
        }
    }
}
