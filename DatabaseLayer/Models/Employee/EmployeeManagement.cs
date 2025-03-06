using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Employee
{
    public class EmployeeManagement
    {
        [Key]
        public int EmployeeManagementId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; } // Employee being managed

        [ForeignKey("Manager")]
        public int ManagerId { get; set; } // The manager

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; } // Nullable, in case the employee is still managed

        // Navigation Properties
        public virtual Employee Employee { get; set; }
        public virtual Employee Manager { get; set; }
    }
}
