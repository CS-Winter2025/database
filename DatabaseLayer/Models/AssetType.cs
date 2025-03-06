using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer.Models
{
    public class AssetType
    {
        [Key]
        public int AssetTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } // Example: "Apartment", "Parking Spot"

        public string Description { get; set; } // Optional description
    }
}
