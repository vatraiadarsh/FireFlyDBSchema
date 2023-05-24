using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace FireFly.Models
{
    public class AutoBudgetDetail : BaseModel
    {
        public Currency Currency { get; set; } = null!;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal AutoBudgetAmount { get; set; }
        public RepeatFrequency RepeatFrequency { get; set; } = null!;
        public ICollection<Attachment>? Attachments { get; set; }
        public bool Status { get; set; }
    }
}
