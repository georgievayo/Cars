using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public int? OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public int? ModelId { get; set; }

        public virtual CarModel Model { get; set; }

        public string Description { get; set; }
    }
}
