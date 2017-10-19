using System;

namespace Cars.Models
{
    public class Car
    {
        public Guid Id { get; set; }

        public Guid? OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public Guid? ModelId { get; set; }

        public virtual CarModel Model { get; set; }

        public string Description { get; set; }
    }
}
