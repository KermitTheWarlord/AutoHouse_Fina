using System.ComponentModel.DataAnnotations;

namespace AutoHouse.Data
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }   // Име (first name of customer)

        [Required]
        public string LastName { get; set; }    // Фамилия (last name)

        [Phone]
        public string PhoneNumber { get; set; } // Телефон

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }       // Имейл (with validation message in Bulgarian)

        // Navigation:
        public ICollection<Sales> Sales { get; set; }   // One-to-many: one customer can have many sales (purchases)
    }
}
