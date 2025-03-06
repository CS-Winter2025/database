using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Asset
{
    public class RentHistory
    {
        [Key]
        public int RentHistoryId { get; set; }

        [ForeignKey("Asset")]
        public int AssetId { get; set; }

        [Required]
        public decimal Amount { get; set; } // Rent at that point in time

        [Required]
        public DateTime EffectiveDate { get; set; } // When rent changed

        public DateTime? EndDate { get; set; } // Nullable if still active

        // Navigation Property
        public virtual Asset Asset { get; set; }
    }
}
