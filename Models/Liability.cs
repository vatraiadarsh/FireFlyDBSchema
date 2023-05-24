using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireFly.Models
{
    public class Liability : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        public Account Account { get; set; } = null!;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal IOweAmount { get; set; }
        public LiabilityInOut LiabilityInOuts { get; set; } = null!;
        public DateTime DebtStartDate { get; set; }
        public int Interest { get; set; }
        public RepeatFrequency RepeatFrequency { get; set; } = null!;
        public bool Status { get; set; }
    }
}
