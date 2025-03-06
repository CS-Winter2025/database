using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [ForeignKey("Resident")]
        public int ResidentId { get; set; }  // Links to a specific Resident

        [Required]
        public DateTime InvoiceDate { get; set; } // Date the invoice was generated

        [Required]
        public DateTime DueDate { get; set; } // Due date for payment

        [Required]
        public decimal TotalAmount { get; set; } // Total amount for the invoice

        [Required]
        [StringLength(50)]
        public string Status { get; set; } // Example: "Pending", "Paid", "Overdue"

        [Required]
        public DateTime CreatedAt { get; set; } // Timestamp of invoice creation

        [Required]
        public DateTime UpdatedAt { get; set; } // Timestamp of last update

        // Navigation Property
        public virtual Resident Resident { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
