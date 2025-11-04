using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Wash.Model
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int PackageId { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [Required]
        public decimal TotalPrice { get; set; }

        [MaxLength(100)]
        public string? PaymentMethod { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client? Client { get; set; }

        [ForeignKey("PackageId")]
        public virtual Package? Package { get; set; }
    }
}
