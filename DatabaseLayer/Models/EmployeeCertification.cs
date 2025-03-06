using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models
{
    public class EmployeeCertification
    {
        [Key]
        public int CertificationId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; } // Employee who owns the certification

        [Required]
        public string CertificationType { get; set; } // Example: First Aid, IT Security, Forklift License

        [Required]
        public string CertificationNumber { get; set; } // Unique identifier for the certification

        [Required]
        public DateTime IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; } // Nullable for non-expiring certifications

        // Navigation Property
        public virtual Employee Employee { get; set; }
    }
}
