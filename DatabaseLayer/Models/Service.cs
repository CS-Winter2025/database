using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [ForeignKey("ServiceType")]
        public int ServiceTypeId { get; set; } // Links to ServiceType

        [Required]
        public decimal Rate { get; set; } // Custom rate (overrides DefaultRate)

        [Required]
        public string Status { get; set; } // Example: "Active", "Inactive"

        // Navigation Property
        public virtual ServiceType ServiceType { get; set; }
    }
}
