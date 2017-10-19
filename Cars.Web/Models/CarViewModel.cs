namespace Cars.Web.Models
{
    public class CarViewModel
    {
        public CarViewModel(int id, int? ownerId, string ownerName, int? modelId, 
            string modelDsc, string description)
        {
            this.Id = id;
            this.OwnerId = ownerId;
            this.OwnerName = ownerName;
            this.ModelId = modelId;
            this.ModelDescription = modelDsc;
            this.Description = description;
        }

        public int Id { get; set; }

        public int? OwnerId { get; set; }

        public string OwnerName { get; set; }

        public int? ModelId { get; set; }

        public string ModelDescription { get; set; }

        public string Description { get; set; }
    }
}