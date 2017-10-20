using System;
using System.Linq;
using System.Web.Mvc;
using Cars.Service.Contracts;
using Cars.Web.Factory;
using Cars.Web.Models;

namespace Cars.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService service;
        private readonly IViewModelFactory factory;

        public HomeController(ICarService service, IViewModelFactory factory)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            this.service = service;
            this.factory = factory;
        }

        // GET /Home/Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetCars(SearchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return this.RedirectToAction("GetCars", new {id = model.OwnerId});
        }

        // GET /Home/GetCars/{id}
        [HttpGet]
        public ActionResult GetCars(int id)
        {
            var model = this.service.GetCarsByOwnerId(id)
                .Select(car => this.factory.CreateCarViewModel(car.Id, car.OwnerId, car.Owner.FullName,
                        car.ModelId, car.Model.Description, car.Description))
                .ToList();

            return View("CarsList", model);
        }
    }
}