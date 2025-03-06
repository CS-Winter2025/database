using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Billing
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }  // Links to a specific Invoice

        [Required]
        public DateTime PaymentDate { get; set; } // Date of the payment

        [Required]
        public decimal Amount { get; set; } // Payment amount

        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; } // Payment method (e.g., "Credit Card", "Cash")

        [Required]
        [StringLength(100)]
        public string TransactionReference { get; set; } // Unique reference for the payment transaction

        // Navigation Property
        public virtual Invoice Invoice { get; set; }
    }
}
