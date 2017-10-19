using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
    public class Owner
    {
        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
