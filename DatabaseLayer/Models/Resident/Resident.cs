using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Resident
{
    public class Resident
    {
        [Key]
        public int ResidentId { get; set; }

        [Required]
        [MaxLength(100)] // Adjust the length as needed
        public string Name { get; set; }

        [ForeignKey("PersonalInfo")]
        public int PersonalInfoId { get; set; } // Foreign Key

        [Required]
        public string Status { get; set; } // You may consider using an Enum if Status has fixed values

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property for the related PersonalInfo entity
        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}
