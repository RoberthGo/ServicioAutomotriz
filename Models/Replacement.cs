using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioAutomotriz.Models
{
    [Table("Replacements")]
    public class Replacement
    {
        [Key]
        [Column("ReplacementID")]
        public int ReplacementID { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("Brand")]
        public string Brand { get; set; } = string.Empty;

        [Column("UnitPrice")]
        public decimal UnitPrice { get; set; }

        [Column("CurrentStock")]
        public int CurrentStock { get; set; }

        [Column("MinimumStock")]
        public int MinimumStock { get; set; }

        [MaxLength(100)]
        [Column("Supplier")]
        public string? Supplier { get; set; }
    }
}
