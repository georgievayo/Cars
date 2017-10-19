using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cars.Web.Models
{
    public class SearchViewModel
    {
        [DisplayName("Owner Id")]
        [Required]
        public int OwnerId { get; set; }
    }
}