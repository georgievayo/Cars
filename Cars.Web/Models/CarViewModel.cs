using Cars.Models;

namespace Cars.Web.Models
{
    public class CarViewModel
    {
        public CarViewModel(Car car)
        {
            this.Id = car.Id;
            this.OwnerId = car.OwnerId;
            this.OwnerName = car.Owner.FullName;
            this.ModelId = car.ModelId;
            this.ModelDescription = car.Model.Description;
            this.Description = car.Description;
        }

        public int Id { get; set; }

        public int? OwnerId { get; set; }

        public string OwnerName { get; set; }

        public int? ModelId { get; set; }

        public string ModelDescription { get; set; }

        public string Description { get; set; }
    }
}