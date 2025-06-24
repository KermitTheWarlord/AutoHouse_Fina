using AutoHouse.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoHouse.Core
{
    public class ServiceController
    {
        private readonly AutoHouseDbContext db;
        public ServiceController(AutoHouseDbContext context) => db = context;

        public async Task ServiceConfigurations()
        {
            using var stream = new FileStream("Data/services.txt", FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);
            if (!db.Services.Any())
            {
                while (!reader.EndOfStream)
                {
                    var parts = (await reader.ReadLineAsync()).Split(',');
                    var service = new Services
                    {
                        Name = parts[0],
                        Description = parts.Length > 1 ? parts[1] : null
                    };
                    await db.Services.AddAsync(service);
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task<List<Services>> GetServicesByCustomer(int customerId)
            => await db.Services
                       .Where(s => s.CarsServices.Any(cs => cs.Car.Sales.Any(sa => sa.CustomerId == customerId)))
                       .ToListAsync();

        public async Task<List<Services>> GetServicesByCar(int carId)
            => await db.Services
                       .Where(s => s.CarsServices.Any(cs => cs.CarId == carId))
                       .ToListAsync();

        public async Task<List<Services>> GetServicesByEmployee(int employeeId)
            => await db.Services
                       .Where(s => s.EmployeesServices.Any(es => es.EmployeeId == employeeId))
                       .ToListAsync();

        public async Task<List<string>> GetTopServices(int topN)
            => await db.CarsServices
                       .GroupBy(cs => cs.Service.Name)
                       .OrderByDescending(g => g.Count())
                       .Take(topN)
                       .Select(g => g.Key)
                       .ToListAsync();

        public async Task<List<Cars>> GetCarsByService(int serviceId)
            => await db.CarsServices
                       .Where(cs => cs.ServiceId == serviceId)
                       .Select(cs => cs.Car)
                       .Distinct()
                       .ToListAsync();
    }
}
