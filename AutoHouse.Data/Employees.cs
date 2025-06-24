using System.ComponentModel.DataAnnotations;

namespace AutoHouse.Data
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Position { get; set; }     // e.g., "Salesperson", "Technician", etc.

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Невалиден имейл адрес")]
        public string Email { get; set; }

        // Navigation:
        public ICollection<EmployeesServices> EmployeesServices { get; set; } // Many-to-many with Service
        public ICollection<Sales> Sales { get; set; }    // One-to-many: an employee can handle many sales (e.g., as salesperson)
    }
}
