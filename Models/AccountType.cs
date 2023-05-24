using System.ComponentModel.DataAnnotations;

namespace FireFly.Models
{
    public class AccountType : BaseModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}