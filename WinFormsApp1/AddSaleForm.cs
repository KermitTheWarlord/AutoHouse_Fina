using System;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class AddSaleForm : Form
    {
        private readonly SaleController saleController;

        public AddSaleForm(
            SaleController saleController,
            CarController carController,
            CustomerController customerController,
            EmployeeController employeeController)
        {
            InitializeComponent();
            this.saleController = saleController;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            int carId, customerId;
            int? employeeId = null;
            decimal price;

            if (!int.TryParse(txtCarId.Text, out carId) ||
                !int.TryParse(txtCustomerId.Text, out customerId) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid IDs and price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmployeeId.Text))
            {
                int empIdParsed;
                if (int.TryParse(txtEmployeeId.Text, out empIdParsed))
                    employeeId = empIdParsed;
            }

            var saleDate = dtSaleDate.Value.Date;

            var newSale = await saleController.AddSale(carId, customerId, employeeId, saleDate, price);
            MessageBox.Show($"Added Sale ID: {newSale.Id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCarId.Clear();
            txtCustomerId.Clear();
            txtEmployeeId.Clear();
            txtPrice.Clear();
            dtSaleDate.Value = DateTime.Today;
        }

        private void AddSaleForm_Load(object sender, EventArgs e)
        {

        }

        private void AddSaleForm_Paint(object sender, PaintEventArgs e)
        {
            
            this.BackColor = System.Drawing.Color.DarkBlue;
        }
    }
}
