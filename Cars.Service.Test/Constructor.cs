using System;
using Cars.Data.Contracts;
using Cars.Models;
using Moq;
using NUnit.Framework;

namespace Cars.Service.Test
{
    [TestFixture]
    public class Constructor
    {
        [Test]
        public void ConstructorShould_DoesNotThrowException_WhenPassedDataIsNotNull()
        {
            var repositoryMock = new Mock<IRepository<Car>>();
            var unitOfWorkMock = new Mock<IUnitOfWork>();

            Assert.DoesNotThrow(() => new CarService(repositoryMock.Object, unitOfWorkMock.Object));
        }

        [Test]
        public void ConstructorShould_SetPassedData_WhenDataIsNotNull()
        {
            var repositoryMock = new Mock<IRepository<Car>>();
            var unitOfWorkMock = new Mock<IUnitOfWork>();

            var service = new CarService(repositoryMock.Object, unitOfWorkMock.Object);

            Assert.IsNotNull(service);
        }

        [Test]
        public void ConstructorShould_ThrowException_WhenRepositoryIsNull()
        {
            var unitOfWorkMock = new Mock<IUnitOfWork>();

            Assert.Throws<ArgumentNullException>(() => new CarService(null, unitOfWorkMock.Object));
        }

        [Test]
        public void ConstructorShould_ThrowException_WhenUnitOfWorkIsNull()
        {
            var repositoryMock = new Mock<IRepository<Car>>();

            Assert.Throws<ArgumentNullException>(() => new CarService(repositoryMock.Object, null));
        }
    }
}
