using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer.Models.Resident
{
    public class ResidentPersonalInfo
    {
        [Key]
        public int PersonalInfoId { get; set; }  // Unique identifier for the personal information record

        [Required]
        [StringLength(100)]
        public string Email { get; set; }  // Resident's email address

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }  // Resident's phone number

        [Required]
        [StringLength(100)]
        public string EmergencyContactName { get; set; }  // Emergency contact's name

        [Required]
        [StringLength(20)]
        public string EmergencyContactPhone { get; set; }  // Emergency contact's phone number

        [Required]
        [StringLength(50)]
        public string EmergencyContactRelationship { get; set; }  // Relationship to the resident

        [Required]
        [StringLength(100)]
        public string FamilyDoctorName { get; set; }  // Family doctor's name

        [Required]
        [StringLength(20)]
        public string FamilyDoctorPhone { get; set; }  // Family doctor's phone number

        public DateTime CreatedAt { get; set; }  // Timestamp when the record was created

        public DateTime UpdatedAt { get; set; }  // Timestamp when the record was last updated
    }
}
