using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioAutomotriz.Models
{
    [Table("Services")]
    public class Service
    {
        [Key]
        [Column("ServiceID")]
        public int ServiceID { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        [Column("Description")]
        public string? Description { get; set; }

        [Column("Cost")]
        public decimal Cost { get; set; }

        [Column("EstimatedTime")]
        public int? EstimatedTime { get; set; }
    }
}
