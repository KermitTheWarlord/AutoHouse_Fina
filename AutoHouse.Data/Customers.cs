using System.ComponentModel.DataAnnotations;

namespace AutoHouse.Data
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }  

        [Required]
        public string LastName { get; set; }   

        [Phone]
        public string PhoneNumber { get; set; } 

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }      

        
        public ICollection<Sales> Sales { get; set; }  
    }
}
