using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Asset
{
    public class OccupancyHistory
    {
        [Key]
        public int OccupancyId { get; set; }

        [ForeignKey("Asset")]
        public int AssetId { get; set; }

        [ForeignKey("Resident")]
        public int ResidentId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; } // Nullable for ongoing rentals

        [Required]
        public decimal MonthlyRent { get; set; } // Rent during this period

        [Required]
        public string Status { get; set; } // Example: "Active", "Completed"

        public string Notes { get; set; } // Any additional comments

        // Navigation Properties
        public virtual Asset Asset { get; set; }
        public virtual Resident Resident { get; set; }
    }
}
