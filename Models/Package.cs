using System;
using System.ComponentModel.DataAnnotations;

namespace Car_Wash.Model
{
    public class Package
    {
        [Key]
        public int PackageId { get; set; }

        [Required]
        [MaxLength(100)]
        public string PackageName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
