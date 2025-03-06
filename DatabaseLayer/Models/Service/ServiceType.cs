
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer.Models.Service
{
    public class ServiceType
    {
        [Key]
        public int ServiceTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } // Example: "Personal Training"

        public string Description { get; set; } // Optional description

        [Required]
        public decimal DefaultRate { get; set; } // Example: $50 per session

        [Required]
        public string ClientType { get; set; } // Example: "Adult", "Child", "Senior"

        public int? MaxGroupSize { get; set; } // Nullable if not a group service

        public string RequiredCertifications { get; set; } // Comma-separated list, e.g., "CPR, First Aid"

        // Navigation Property
        public virtual ICollection<Service> Services { get; set; }
    }
}
