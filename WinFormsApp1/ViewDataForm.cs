using System;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class ViewDataForm : Form
    {
        private readonly CarController carController;
        private readonly CustomerController customerController;
        private readonly EmployeeController employeeController;
        private readonly ServiceController serviceController;
        private readonly SaleController saleController;

        public ViewDataForm(
            CarController carController,
            CustomerController customerController,
            EmployeeController employeeController,
            ServiceController serviceController,
            SaleController saleController)
        {
            InitializeComponent();
            this.carController = carController;
            this.customerController = customerController;
            this.employeeController = employeeController;
            this.serviceController = serviceController;
            this.saleController = saleController;
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            var f = new ViewCarForm(carController, serviceController);
            f.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var f = new ViewCustomerForm(customerController, serviceController);
            f.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            var f = new ViewEmployeeForm(employeeController, serviceController);
            f.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var f = new ViewSalesForm(saleController, carController, customerController);
            f.ShowDialog();
        }
    }
}
