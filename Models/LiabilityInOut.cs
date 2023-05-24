using System.ComponentModel.DataAnnotations;

namespace FireFly.Models
{
    public class LiabilityInOut : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        public string? Notes { get; set; }
        public bool Status { get; set; }
    }
}
