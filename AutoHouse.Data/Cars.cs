using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoHouse.Data
{
    public class Cars  
    {
        [Key]  
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }      

        [Required]
        public string Model { get; set; }    

        public int Year { get; set; }        

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }   

        public ICollection<CarsServices> CarsServices { get; set; }  
        public ICollection<Sales> Sales { get; set; }                
    }
}
