using AutoHouse.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoHouse.Core
{
    public class SaleController
    {
        private AutoHouseDbContext db;
        public SaleController(AutoHouseDbContext context) { this.db = context; }

        public async Task SaleConfigurations()
        {
            using var stream = new FileStream("Data/sales.txt", FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);
            if (!db.Sales.Any())
            {
                while (!reader.EndOfStream)
                {
                    var parts = (await reader.ReadLineAsync()).Split(',');
                    var sale = new Sales
                    {
                        CarId = int.Parse(parts[0]),
                        CustomerId = int.Parse(parts[1]),
                        EmployeeId = string.IsNullOrEmpty(parts[2]) ? (int?)null : int.Parse(parts[2]),
                        Date = DateTime.Parse(parts[3]),
                        Price = decimal.Parse(parts[4])
                    };
                    await db.Sales.AddAsync(sale);
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task<Sales> AddSale(int carId, int custId, int? empId, DateTime date, decimal price)
        {
            var sale = new Sales { CarId = carId, CustomerId = custId, EmployeeId = empId, Date = date, Price = price };
            await db.Sales.AddAsync(sale);
            await db.SaveChangesAsync();
            return sale;
        }

        public async Task<Sales> GetSaleById(int id)
            => await db.Sales
                       .Include(s => s.Car)
                       .Include(s => s.Customer)
                       .Include(s => s.Employee)
                       .FirstOrDefaultAsync(s => s.Id == id);

        public async Task<bool> DeleteSale(int id)
        {
            var sale = await db.Sales.FindAsync(id);
            if (sale != null)
            {
                db.Sales.Remove(sale);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<List<Sales>> GetSalesByDateRange(DateTime startDate, DateTime endDate)
            => await db.Sales
                       .Include(s => s.Car)
                       .Include(s => s.Customer)
                       .Include(s => s.Employee)
                       .Where(s => s.Date >= startDate && s.Date <= endDate)
                       .ToListAsync();

        public async Task<Dictionary<string, int>> GetSalesCountByCustomer()
            => await db.Sales
                       .GroupBy(s => s.Customer.FirstName + " " + s.Customer.LastName)
                       .ToDictionaryAsync(g => g.Key, g => g.Count());

        public async Task<List<Sales>> GetSalesByCustomer(int customerId)
            => await db.Sales
                       .Include(s => s.Car)
                       .Include(s => s.Customer)
                       .Include(s => s.Employee)
                       .Where(s => s.CustomerId == customerId)
                       .ToListAsync();
    }
}
