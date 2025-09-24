using System;
using System.Windows.Forms;
using AutoHouse.Core;
using AutoHouse.Data;

namespace AutoHouse.WinFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Prepare DB context and controllers
            var dbContext = new AutoHouseDbContext();
            var carController = new CarController(dbContext);
            var customerController = new CustomerController(dbContext);
            var employeeController = new EmployeeController(dbContext);
            var serviceController = new ServiceController(dbContext);
            var saleController = new SaleController(dbContext);

            // Seed initial data
            carController.CarConfigurations().Wait();
            customerController.CustomerConfigurations().Wait();
            employeeController.EmployeeConfigurations().Wait();
            serviceController.ServiceConfigurations().Wait();
            saleController.SaleConfigurations().Wait();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(
                carController,
                customerController,
                employeeController,
                serviceController,
                saleController
            ));
        }
    }
}
