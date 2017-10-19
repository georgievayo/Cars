using Cars.Service.Contracts;
using Cars.Web.Controllers;
using Cars.Web.Factory;
using Moq;
using NUnit.Framework;
using TestStack.FluentMVCTesting;

namespace Cars.Web.Test
{
    [TestFixture]
    public class Index
    {
        [Test]
        public void IndexShould_RenderDefaultView()
        {
            var serviceMock = new Mock<ICarService>();
            var factoryMock = new Mock<IViewModelFactory>();

            var controller = new HomeController(serviceMock.Object, factoryMock.Object);

            controller
                .WithCallTo(c => c.Index())
                .ShouldRenderDefaultView();
        }
    }
}
