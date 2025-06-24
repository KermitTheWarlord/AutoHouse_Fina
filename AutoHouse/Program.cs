using AutoHouse.Core;
using AutoHouse.Data;
using System.Threading.Tasks;

namespace AutoHouse.ConsoleApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            AutoHouseDbContext dbContext = new AutoHouseDbContext();

            var carController = new CarController(dbContext);
            var customerController = new CustomerController(dbContext);
            var employeeController = new EmployeeController(dbContext);
            var serviceController = new ServiceController(dbContext);
            var saleController = new SaleController(dbContext);
            var carServiceController = new CarServiceController(dbContext);
            var employeeServiceController = new EmployeeServiceController(dbContext);

            var display = new Display(carController, customerController,
                                      employeeController, serviceController,
                                      saleController, carServiceController,
                                      employeeServiceController);
            await display.ControllerConfiguration();
            await display.ShowMenu();
        }
    }
}
