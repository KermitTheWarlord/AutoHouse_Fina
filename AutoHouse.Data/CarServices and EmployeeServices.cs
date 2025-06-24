using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AutoHouse.Data
{
    public class CarsServices
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }
        public Cars Car { get; set; }

        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        public Services Service { get; set; }
    }

    public class EmployeesServices
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        public Services Service { get; set; }
    }
}
