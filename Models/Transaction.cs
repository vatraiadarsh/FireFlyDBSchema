using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireFly.Models
{
    public class Transaction : BaseModel
    {
        public TransactionType TransactionTypes { get; set; } = null!;
        public string? Description { get; set; }
        public string? SourceAccount { get; set; }
        public string? DestinationAccount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ForeignAmount { get; set; }

        [ForeignKey("Currency")]
        public Guid CurrencyId { get; set; }
        public Currency Currency { get; set; } = null!;

        [ForeignKey("Budget")]
        public Guid BudgetId { get; set; }
        public Budget Budget { get; set; } = null!;     
        public Category Categories { get; set; } = null!;       
        public Tag Tags { get; set; } = null!;
        public Bill Bills { get; set; } = null!;
        public DateTime InterestDate { get; set; }
        public ICollection<Attachment> Attachments { get; set; } = null!;
        public string? Notes { get; set; }
        public bool Status { get; set; }
    }
}
