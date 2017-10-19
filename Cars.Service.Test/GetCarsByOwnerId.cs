using System;
using System.Collections.Generic;
using System.Linq;
using Cars.Data.Contracts;
using Cars.Models;
using Moq;
using NUnit.Framework;

namespace Cars.Service.Test
{
    [TestFixture]
    public class GetCarsByOwnerId
    {
        [Test]
        public void GetCarsByOwnerIdShould_CallRepositoryPropertyAll()
        {
            var repositoryMock = new Mock<IRepository<Car>>();
            var unitOfWorkMock = new Mock<IUnitOfWork>();

            var service = new CarService(repositoryMock.Object, unitOfWorkMock.Object);

            var ownerId = 1;

            service.GetCarsByOwnerId(ownerId);

            repositoryMock.Verify(r => r.All, Times.Once);
        }

        [Test]
        public void GetCarsByOwnerIdShould_ReturnCorrectResult()
        {
            var repositoryMock = new Mock<IRepository<Car>>();
            var unitOfWorkMock = new Mock<IUnitOfWork>();

            var service = new CarService(repositoryMock.Object, unitOfWorkMock.Object);

            var ownerId = 1;
            var allCars = new List<Car>()
            {
                new Car()
                {
                    OwnerId = ownerId
                },
                new Car()
                {
                    OwnerId = 2
                }
            };

            repositoryMock.Setup(r => r.All).Returns(allCars.AsQueryable());

            var result = service.GetCarsByOwnerId(ownerId);

            Assert.AreEqual(1, result.Count);
        }
    }
}
