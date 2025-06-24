using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AutoHouse.Data
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public Cars Car { get; set; }          // The car that was sold in this sale

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customers Customer { get; set; } // The customer who bought the car

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employees Employee { get; set; } // (Optional) Employee who handled the sale

        [Required]
        public DateTime Date { get; set; }     // Date of sale

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }     // Sale price

        // No collections here; this is a linking entity in one-to-many relations
    }
}
