using System.ComponentModel.DataAnnotations;

namespace AutoHouse.Data
{
    public class Services
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }        // Service name (e.g., "Oil Change", "Технически преглед")

        public string Description { get; set; } // Description/details of the service

        // Navigation:
        public ICollection<CarsServices> CarsServices { get; set; }         // Many-to-many with Car
        public ICollection<EmployeesServices> EmployeesServices { get; set; } // Many-to-many with Employee
    }
}
