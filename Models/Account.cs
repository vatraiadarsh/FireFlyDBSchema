using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireFly.Models
{
    public class Account : BaseModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; } = string.Empty;
        public Currency Currency { get; set; } = null!;
        public AccountType AccountType { get; set; } = null!;
        public int BSB { get; set; }
        public int AccountNumber { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal OpeningBalance { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal VirtualBalance { get; set; }
        public string? Notes { get; set; }
        public Location Location { get; set; } = null!;
        public ICollection<Attachment>? Attachments { get; set; }
        public bool Status { get; set; }
    }
}
