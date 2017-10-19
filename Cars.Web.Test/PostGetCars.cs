using Cars.Service.Contracts;
using Cars.Web.Controllers;
using Cars.Web.Factory;
using Cars.Web.Models;
using Moq;
using NUnit.Framework;
using TestStack.FluentMVCTesting;

namespace Cars.Web.Test
{
    [TestFixture]
    public class PostGetCars
    {
        [Test]
        public void PostGetCars_ShouldRenderErrorView_WhenModelIsNotValid()
        {
            var serviceMock = new Mock<ICarService>();
            var factoryMock = new Mock<IViewModelFactory>();

            var controller = new HomeController(serviceMock.Object, factoryMock.Object);
            controller.ModelState.AddModelError("key", "message");
            var model = new SearchViewModel()
            {
                OwnerId = -5
            };

            controller
                .WithCallTo(c => c.GetCars(model))
                .ShouldRenderView("Error");
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void PostGetCars_ShouldRedirectToGetCars_WhenModelIsValid(int ownerId)
        {
            var serviceMock = new Mock<ICarService>();
            var factoryMock = new Mock<IViewModelFactory>();

            var controller = new HomeController(serviceMock.Object, factoryMock.Object);
            var model = new SearchViewModel()
            {
                OwnerId = ownerId
            };

            controller
                .WithCallTo(c => c.GetCars(model))
                .ShouldRedirectTo((HomeController c) => c.GetCars(model.OwnerId));
        }
    }
}
