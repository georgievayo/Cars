using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
