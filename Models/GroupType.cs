using System.ComponentModel.DataAnnotations;

namespace FireFly.Models
{
    public class GroupType : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}