using System;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly CarController carController;
        private readonly CustomerController customerController;
        private readonly EmployeeController employeeController;
        private readonly ServiceController serviceController;
        private readonly SaleController saleController;

        public MainForm(
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

        private void btnAddData_Click(object sender, EventArgs e)
        {
            var addForm = new AddDataForm(
                carController, customerController, employeeController,
                serviceController, saleController
            );
            addForm.ShowDialog();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewDataForm(
                carController, customerController, employeeController,
                serviceController, saleController
            );
            viewForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
