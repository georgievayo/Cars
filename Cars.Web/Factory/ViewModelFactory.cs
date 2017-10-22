using Cars.Models;
using Cars.Web.Models;

namespace Cars.Web.Factory
{
    public interface IViewModelFactory
    {
        CarViewModel CreateCarViewModel(Car car);
    }
}