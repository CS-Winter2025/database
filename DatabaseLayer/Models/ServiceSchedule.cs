using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models
{
    public class ServiceSchedule
    {
        [Key]
        public int ServiceScheduleId { get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; } // Links to a specific Service

        [Required]
        public DateTime ScheduleDate { get; set; } // Date of service

        [Required]
        public TimeSpan StartTime { get; set; } // When the service starts

        [Required]
        public TimeSpan EndTime { get; set; } // When the service ends

        [Required]
        public string Status { get; set; } // Example: "Scheduled", "Completed", "Cancelled"

        // Navigation Property
        public virtual Service Service { get; set; }
    }
}
