using System.ComponentModel.DataAnnotations;

namespace FireFly.Models
{
    public class RepeatFrequency : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Repeat Frequency is required")]
        public int Days { get; set; }
        public bool Status { get; set; }
    }
}