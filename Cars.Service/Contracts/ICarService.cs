using System;
using System.Collections.Generic;
using Cars.Models;

namespace Cars.Service.Contracts
{
    public interface ICarService
    {
        ICollection<Car> GetCarsByOwnerId(Guid? ownerId);
    }
}
