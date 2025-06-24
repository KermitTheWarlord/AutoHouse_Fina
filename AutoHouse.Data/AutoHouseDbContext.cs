using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AutoHouse.Data
{
    public class AutoHouseDbContext : DbContext
    {
        public AutoHouseDbContext() : base() { }
        public AutoHouseDbContext(DbContextOptions<AutoHouseDbContext> options) : base(options) { }

        // DbSet properties for each entity:
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<CarsServices> CarsServices { get; set; }
        public DbSet<EmployeesServices> EmployeesServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // We could configure composite keys or relationships here if needed.
            // (In this case, data annotations cover our needs, so no additional configuration required.)
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Define the connection string to the SQL Server database.
            // TODO: Replace with your actual server name/credentials.
            optionsBuilder.UseSqlServer(
                "Data Source = LAPTOP-PSUITNF6\\SQLEXPRESS; Initial Catalog = AutoHouse; Integrated Security = True; Encrypt = True; Trust Server Certificate = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
