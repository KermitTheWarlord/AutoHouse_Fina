using AutoHouse.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoHouse.Core
{
    public class RentalController
    {
        private readonly AutoHouseDbContext db;
        public RentalController(AutoHouseDbContext context) { db = context; }

        public async Task<List<Rental>> GetAllRentals()
        {
            return await db.Rentals.Include(r => r.Car).Include(r => r.Customer).ToListAsync();
        }

        public async Task<bool> IsCarAvailable(int carId, DateTime start, DateTime end)
        {
            return !await db.Rentals.AnyAsync(r =>
                r.CarId == carId &&
                ((start >= r.StartDate && start <= r.EndDate) ||
                 (end >= r.StartDate && end <= r.EndDate) ||
                 (start <= r.StartDate && end >= r.EndDate))
            );
        }

        public async Task<Rental> AddRental(int carId, int customerId, DateTime start, DateTime end)
        {
            var car = await db.Cars.FindAsync(carId);
            if (car == null) throw new Exception("Car not found");

            if (!await IsCarAvailable(carId, start, end))
                throw new Exception("Car is not available for the selected dates.");

            var days = (end - start).Days + 1;
            if (days <= 0) throw new Exception("End date must be after start date.");

            var pricePerDay = car.Price * 0.10m;
            var totalPrice = days * pricePerDay;

            var rental = new Rental
            {
                CarId = carId,
                CustomerId = customerId,
                StartDate = start,
                EndDate = end,
                PricePerDay = pricePerDay,
                TotalPrice = totalPrice
            };

            db.Rentals.Add(rental);
            await db.SaveChangesAsync();
            return rental;
        }

        public async Task<List<Rental>> GetRentalsByCar(int carId)
        {
            return await db.Rentals.Include(r => r.Car).Include(r => r.Customer)
                .Where(r => r.CarId == carId).ToListAsync();
        }
    }
}