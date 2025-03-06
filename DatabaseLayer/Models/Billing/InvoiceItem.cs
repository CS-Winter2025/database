using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Billing
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }  // Links to a specific Invoice

        [Required]
        [StringLength(50)]
        public string Type { get; set; } // Type of the item (e.g., Service, Product)

        [Required]
        public string Description { get; set; } // Description of the item

        [Required]
        public decimal Amount { get; set; } // Amount for this invoice item

        public int? ServiceScheduleId { get; set; } // Optional foreign key for service schedule
        public int? OccupancyId { get; set; } // Optional foreign key for occupancy

        // Navigation Properties
        public virtual Invoice Invoice { get; set; }
        public virtual ServiceSchedule ServiceSchedule { get; set; }
    }
}
