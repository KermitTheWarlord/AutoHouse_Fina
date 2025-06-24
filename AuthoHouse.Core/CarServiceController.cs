using AutoHouse.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace AutoHouse.Core
{
    public class CarServiceController
    {
        private AutoHouseDbContext db;
        public CarServiceController(AutoHouseDbContext context) { this.db = context; }

        public async Task CarServiceConfigurations()
        {
            using var stream = new FileStream("C:\\Users\\tonys\\source\\repos\\AutoHouse\\AutoHouse\\Data\\carservices.txt", FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);
            if (!db.CarsServices.Any())
            {
                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();
                    var parts = line.Split(',');
                    var cs = new CarsServices
                    {
                        CarId = int.Parse(parts[0]),
                        ServiceId = int.Parse(parts[1])
                    };
                    await db.CarsServices.AddAsync(cs);
                    await db.SaveChangesAsync();
                }
            }
        }
    }

    public class EmployeeServiceController
    {
        private AutoHouseDbContext db;
        public EmployeeServiceController(AutoHouseDbContext context) { this.db = context; }

        public async Task EmployeeServiceConfigurations()
        {
            using var stream = new FileStream("Data\\employeeservices.txt", FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);
            if (!db.EmployeesServices.Any())
            {
                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();
                    var parts = line.Split(',');
                    var es = new EmployeesServices
                    {
                        EmployeeId = int.Parse(parts[0]),
                        ServiceId = int.Parse(parts[1])
                    };
                    await db.EmployeesServices.AddAsync(es);
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
