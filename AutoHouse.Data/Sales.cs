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
        public Cars Car { get; set; }          

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customers Customer { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employees Employee { get; set; } 

        [Required]
        public DateTime Date { get; set; }     

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }    
    }
}
