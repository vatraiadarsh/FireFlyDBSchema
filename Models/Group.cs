using System.ComponentModel.DataAnnotations;

namespace FireFly.Models
{
    public class Group : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        public GroupType? GroupType { get; set; }       
        public bool Status { get; set; }
    }
}
