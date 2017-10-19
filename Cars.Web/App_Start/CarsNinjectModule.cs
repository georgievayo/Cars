using Cars.Data;
using Cars.Data.Contracts;
using Cars.Service;
using Cars.Service.Contracts;
using Cars.Web.Factory;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Cars.Web
{
    public class CarsNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<CarsDbContext>().ToSelf().InRequestScope();
            this.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            this.Bind(typeof(IRepository<>)).To(typeof(Repository<>)).InRequestScope();
            this.Bind<ICarService>().To<CarService>().InRequestScope();
            this.Bind<IViewModelFactory>().ToFactory();
        }
    }
}