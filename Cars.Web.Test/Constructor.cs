using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Service;
using Cars.Service.Contracts;
using Cars.Web.Controllers;
using Cars.Web.Factory;
using Moq;
using NUnit.Framework;

namespace Cars.Web.Test
{
    [TestFixture]
    public class Constructor
    {
        [Test]
        public void ConstructorShould_DoesNotThrowException_WhenPassedDataIsNotNull()
        {
            var serviceMock = new Mock<ICarService>();
            var factoryMock = new Mock<IViewModelFactory>();

            Assert.DoesNotThrow(() => new HomeController(serviceMock.Object, factoryMock.Object));
        }

        [Test]
        public void ConstructorShould_SetPassedData_WhenDataIsNotNull()
        {
            var serviceMock = new Mock<ICarService>();
            var factoryMock = new Mock<IViewModelFactory>();

            var controller = new HomeController(serviceMock.Object, factoryMock.Object);

            Assert.IsNotNull(controller);
        }

        [Test]
        public void ConstructorShould_ThrowException_WhenServiceIsNull()
        {
           var factoryMock = new Mock<IViewModelFactory>();

            Assert.Throws<ArgumentNullException>(() => new HomeController(null, factoryMock.Object));
        }

        [Test]
        public void ConstructorShould_ThrowException_WhenFactoryIsNull()
        {
            var serviceMock = new Mock<ICarService>();

            Assert.Throws<ArgumentNullException>(() => new HomeController(serviceMock.Object, null));
        }
    }
}
