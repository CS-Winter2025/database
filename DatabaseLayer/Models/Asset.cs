using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models
{
    public class Asset
    {
        [Key]
        public int AssetId { get; set; }

        [ForeignKey("AssetType")]
        public int AssetTypeId { get; set; } // Links to AssetType

        [Required]
        public string AssetNumber { get; set; } // Example: "APT-101", "PARK-5"

        [Required]
        public string Status { get; set; } // Example: "Available", "Occupied", "Under Maintenance"

        public decimal? CurrentRent { get; set; } // Optional rent value

        public string Features { get; set; } // Example: "2 bed, 2 bath, balcony"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Property
        public virtual AssetType AssetType { get; set; }
    }
}
