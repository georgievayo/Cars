using System.Collections.Generic;
using Cars.Models;
using Cars.Service.Contracts;
using Cars.Web.Controllers;
using Cars.Web.Factory;
using Moq;
using NUnit.Framework;
using TestStack.FluentMVCTesting;

namespace Cars.Web.Test
{
    [TestFixture]
    public class GetGetCars
    {
        [TestCase(1)]
        public void GetGetCarsShould_CallServiceMethodGetCarsByOwnerId(int ownerId)
        {
            var serviceMock = new Mock<ICarService>();
            var factoryMock = new Mock<IViewModelFactory>();

            var controller = new HomeController(serviceMock.Object, factoryMock.Object);
            serviceMock.Setup(s => s.GetCarsByOwnerId(ownerId)).Returns(new List<Car>());

            controller.GetCars(ownerId);
            serviceMock.Verify(s => s.GetCarsByOwnerId(ownerId), Times.Once);
        }

        [TestCase(1)]
        public void GetGetCarsShould_RenderCarsListView(int ownerId)
        {
            var serviceMock = new Mock<ICarService>();
            var factoryMock = new Mock<IViewModelFactory>();

            var controller = new HomeController(serviceMock.Object, factoryMock.Object);
            serviceMock.Setup(s => s.GetCarsByOwnerId(ownerId)).Returns(new List<Car>());
            var model = new List();

            controller
                .WithCallTo(c => c.GetCars(ownerId))
                .ShouldRenderView("CarsList");
        }
    }
}
