using System;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class AddDataForm : Form
    {
        private readonly CarController carController;
        private readonly CustomerController customerController;
        private readonly EmployeeController employeeController;
        private readonly ServiceController serviceController;
        private readonly SaleController saleController;

        public AddDataForm(
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

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var f = new AddCarForm(carController);
            f.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var f = new AddCustomerForm(customerController);
            f.ShowDialog();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var f = new AddEmployeeForm(employeeController);
            f.ShowDialog();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            var f = new AddSaleForm(saleController, carController, customerController, employeeController);
            f.ShowDialog();
        }

        private void btnAddCar_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkBlue;

        }

        private void AddDataForm_Load(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.Color.DarkBlue;
        }

        private void AddDataForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
