using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Asset
{
    public class ResidentAsset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResidentAssetId { get; set; } // New primary key

        [ForeignKey("Resident")]
        public int ResidentId { get; set; } // Links to Resident

        [ForeignKey("Asset")]
        public int AssetId { get; set; } // Links to Asset

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; } // Nullable if still active

        [Required]
        public decimal CurrentRent { get; set; } // Rent during this period

        [Required]
        public string Status { get; set; } // Example: "Active", "Terminated"

        // Navigation Properties
        public virtual Resident Resident { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
