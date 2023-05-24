using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireFly.Models
{
    public class Currency : BaseModel
    {
        [Required(ErrorMessage ="Symbol is required")]
        public string Symbol { get; set; } = string.Empty;

        [Required(ErrorMessage = "IsoCode is required")]
        public string IsoCode { get; set; } = string.Empty;
        public bool Status { get; set; }

    }
}