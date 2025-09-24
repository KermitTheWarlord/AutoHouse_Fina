using System.ComponentModel.DataAnnotations;

namespace AutoHouse.Data
{
    public class Services
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }        

        public string Description { get; set; }

        public ICollection<CarsServices> CarsServices { get; set; }         
        public ICollection<EmployeesServices> EmployeesServices { get; set; } 
    }
}
