using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string JobTitle { get; set; }

        [Required]
        public string EmploymentType { get; set; } // Example: Full-Time, Part-Time, Contract

        [Required]
        public string PayType { get; set; } // Example: Hourly, Salary

        [Required]
        public decimal CurrentRate { get; set; } // Salary or hourly rate

        [Required]
        public string Status { get; set; } // Example: Active, Terminated

        [Required]
        [MaxLength(20)]
        public string SocialInsurance { get; set; } // SIN (Social Insurance Number)

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        // Emergency Contact
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }

        // Banking Information
        public string DirectDepositInfo { get; set; } // You might want to encrypt this in real-world apps

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
