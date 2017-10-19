using System;
using System.Collections.Generic;

namespace Cars.Models
{
    public class CarModel
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
