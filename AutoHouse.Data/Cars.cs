using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoHouse.Data
{
    public class Cars  // Following the CinemaCenter naming style (class name in plural)
    {
        [Key]  // Primary key
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }       // e.g., car manufacturer (марка)

        [Required]
        public string Model { get; set; }      // e.g., model name (модел)

        public int Year { get; set; }          // year of manufacture

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }     // price of the car

        // Navigation properties:
        public ICollection<CarsServices> CarsServices { get; set; }  // Many-to-many with Service
        public ICollection<Sales> Sales { get; set; }                // One-to-many with Sale (if a car can be sold)
    }
}
