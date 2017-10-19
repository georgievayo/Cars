using Cars.Data;
using Cars.Data.Contracts;
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
        }
    }
}