using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Resident
{
    public class EmergencyContact
    {
        [Key]
        public int EmergencyContactId { get; set; }

        [ForeignKey("ResidentPersonalInfo")]
        public int PersonalInfoId { get; set; } // Foreign Key to ResidentPersonalInfo

        [Required]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        public string Relationship { get; set; }

        // Navigation property
        public virtual ResidentPersonalInfo ResidentPersonalInfo { get; set; }
    }
}
