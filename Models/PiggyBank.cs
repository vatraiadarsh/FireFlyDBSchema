using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireFly.Models
{
    public class PiggyBank : BaseModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; } = string.Empty;
        public AccountType AccountTypes { get; set; } = null!;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TargetAmount { get; set; }
        public string? Notes { get; set; }
        public ICollection<Attachment>? Attachments { get; set; }
        public Group Group { get; set; } = null!;
        public bool Status { get; set; }
    }
}
