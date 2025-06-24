using AutoHouse.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoHouse.Core
{
    public class CustomerController
    {
        private AutoHouseDbContext db;
        public CustomerController(AutoHouseDbContext context) { this.db = context; }

        public async Task CustomerConfigurations()
        {
            using var stream = new FileStream("Data/customers.txt", FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);
            if (!db.Customers.Any())
            {
                while (!reader.EndOfStream)
                {
                    var parts = (await reader.ReadLineAsync()).Split(',');
                    var customer = new Customers
                    {
                        FirstName = parts[0],
                        LastName = parts[1],
                        PhoneNumber = parts[2],
                        Email = parts[3]
                    };
                    await db.Customers.AddAsync(customer);
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task<Customers> AddCustomer(string firstName, string lastName, string phone, string email)
        {
            var customer = new Customers { FirstName = firstName, LastName = lastName, PhoneNumber = phone, Email = email };
            await db.Customers.AddAsync(customer);
            await db.SaveChangesAsync();
            return customer;
        }

        public async Task<Customers> GetCustomerById(int id)
            => await db.Customers.FindAsync(id);

        public async Task<Customers> UpdateCustomer(int id, string newPhone, string newEmail)
        {
            var customer = await db.Customers.FindAsync(id);
            if (customer != null)
            {
                customer.PhoneNumber = newPhone;
                customer.Email = newEmail;
                db.Customers.Update(customer);
                await db.SaveChangesAsync();
            }
            return customer;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            var customer = await db.Customers.FindAsync(id);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Customers>> GetCustomersByLastName(string lastName)
            => await db.Customers.Where(c => c.LastName == lastName).ToListAsync();

        public async Task<List<Customers>> GetCustomersByEmailDomain(string domain)
            => await db.Customers
                       .Where(c => c.Email.EndsWith($"@{domain}"))
                       .ToListAsync();
    }
}
