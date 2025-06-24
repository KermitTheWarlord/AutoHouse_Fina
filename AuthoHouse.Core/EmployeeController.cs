using AutoHouse.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoHouse.Core
{
    public class EmployeeController
    {
        private AutoHouseDbContext db;
        public EmployeeController(AutoHouseDbContext context) { this.db = context; }

        public async Task EmployeeConfigurations()
        {
            using var stream = new FileStream("Data/employees.txt", FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);
            if (!db.Employees.Any())
            {
                while (!reader.EndOfStream)
                {
                    var parts = (await reader.ReadLineAsync()).Split(',');
                    var employee = new Employees
                    {
                        FirstName = parts[0],
                        LastName = parts[1],
                        Position = parts[2],
                        PhoneNumber = parts[3],
                        Email = parts[4]
                    };
                    await db.Employees.AddAsync(employee);
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task<Employees> AddEmployee(string firstName, string lastName, string position, string phone, string email)
        {
            var emp = new Employees { FirstName = firstName, LastName = lastName, Position = position, PhoneNumber = phone, Email = email };
            await db.Employees.AddAsync(emp);
            await db.SaveChangesAsync();
            return emp;
        }

        public async Task<Employees> GetEmployeeById(int id)
            => await db.Employees.FindAsync(id);

        public async Task<Employees> UpdateEmployee(int id, string newPosition, string newPhone)
        {
            var emp = await db.Employees.FindAsync(id);
            if (emp != null)
            {
                emp.Position = newPosition;
                emp.PhoneNumber = newPhone;
                db.Employees.Update(emp);
                await db.SaveChangesAsync();
            }
            return emp;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var emp = await db.Employees.FindAsync(id);
            if (emp != null)
            {
                db.Employees.Remove(emp);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Employees>> GetEmployeesByService(int serviceId)
            => await db.Employees
                       .Where(e => e.EmployeesServices.Any(es => es.ServiceId == serviceId))
                       .ToListAsync();

        public async Task<List<Employees>> GetEmployeesByPosition(string position)
            => await db.Employees.Where(e => e.Position == position).ToListAsync();
    }
}
