using Cars.Web.Models;

namespace Cars.Web.Factory
{
    public interface IViewModelFactory
    {
        CarViewModel CreateCarViewModel(int id, int? ownerId, string ownerName, int? modelId,
            string modelDsc, string description);
    }
}