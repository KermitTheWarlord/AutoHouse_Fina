using AutoHouse.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace AutoHouse.Core
{
    public class CarController
    {
        private AutoHouseDbContext db;
        public CarController(AutoHouseDbContext context) { this.db = context; }

        public async Task CarConfigurations()
        {
            using var stream = new FileStream("C:\\Users\\tonys\\source\\repos\\AutoHouse\\AutoHouse\\Data\\cars.txt", FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);
            if (!db.Cars.Any())  
            {
                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();
                    var parts = line.Split(',');
                    var car = new Cars
                    {
                        Make = parts[0],
                        Model = parts[1],
                        Year = int.Parse(parts[2]),
                        Price = decimal.Parse(parts[3])
                    };
                    await db.Cars.AddAsync(car);
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task<Cars> AddCar(string make, string model, int year, decimal price)
        {
            var car = new Cars { Make = make, Model = model, Year = year, Price = price };
            await db.Cars.AddAsync(car);
            await db.SaveChangesAsync();
            return car;
        }

        public async Task<Cars> GetCarById(int id)
        {
            return await db.Cars.FindAsync(id);
        }

        public async Task<Cars> UpdateCarPrice(int id, decimal newPrice)
        {
            var car = await db.Cars.FindAsync(id);
            if (car != null)
            {
                car.Price = newPrice;
                db.Cars.Update(car);
                await db.SaveChangesAsync();
            }
            return car;
        }

        public async Task<bool> DeleteCar(int id)
        {
            var car = await db.Cars.FindAsync(id);
            if (car != null)
            {
                db.Cars.Remove(car);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Cars>> GetCarsByMake(string make)
        {
            return await db.Cars.Where(c => c.Make == make).ToListAsync();
        }
        public async Task<List<Cars>> GetCarsByPriceRange(decimal min, decimal max)
        => await db.Cars
               .Where(c => c.Price >= min && c.Price <= max)
               .ToListAsync();
        
    
    }
}
