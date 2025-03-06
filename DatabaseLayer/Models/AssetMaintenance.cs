using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models
{
    public class AssetMaintenance
    {
        [Key]
        public int MaintenanceId { get; set; }  // Unique identifier for the maintenance record

        [ForeignKey("Asset")]
        public int AssetId { get; set; }  // Links to a specific Asset

        [Required]
        [StringLength(100)]
        public string ReportedBy { get; set; }  // Name or ID of the person reporting the issue

        [Required]
        public DateTime ReportDate { get; set; }  // Date when the issue was reported

        [Required]
        public string Issue { get; set; }  // Description of the issue

        [Required]
        [StringLength(50)]
        public string Status { get; set; }  // Current status of the maintenance (e.g., "Pending", "In Progress", "Completed")

        public string Resolution { get; set; }  // Resolution or steps taken to fix the issue

        public DateTime? CompletedDate { get; set; }  // Date when the maintenance was completed (nullable)

        // Navigation Property
        public virtual Asset Asset { get; set; }  // The asset that the maintenance is associated with
    }
}
