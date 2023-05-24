using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace FireFly.Models
{
    public class Bill : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        public Currency Currency { get; set; } = null!;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal MinimumAmount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal MaximumAmount { get; set; }
        public DateTime Date { get; set; }
        public RepeatFrequency RepeatFrequency { get; set; } = null!;
        public int Skip { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ExtensionDate { get; set; }
        public string? Notes { get; set; }
        public Group Group { get; set; } = null!;
        public bool Status { get; set; }
    }
}
