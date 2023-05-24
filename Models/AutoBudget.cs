using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireFly.Models
{
    public class AutoBudget : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        public AutoBudgetDetail AutoBudgetDetail { get; set; } = null!;
        public bool Status { get; set; }
    }
}
