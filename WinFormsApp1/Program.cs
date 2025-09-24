using System;
using System.Windows.Forms;

namespace AutoHouse.WinFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Setup your DbContext and controllers here:
            var db = new AutoHouse.Data.AutoHouseDbContext();

            // You may want to initialize your controllers once and pass them to MainForm.
            var carController = new AutoHouse.Core.CarController(db);
            var customerController = new AutoHouse.Core.CustomerController(db);
            var employeeController = new AutoHouse.Core.EmployeeController(db);
            var serviceController = new AutoHouse.Core.ServiceController(db);
            var saleController = new AutoHouse.Core.SaleController(db);

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
