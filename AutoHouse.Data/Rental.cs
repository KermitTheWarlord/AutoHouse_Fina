using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoHouse.Data
{
    public class Rental
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

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }
    }
}