using System;
using System.Linq;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class ViewSalesForm : Form
    {
        private readonly SaleController saleController;
        private readonly CarController carController;
        private readonly CustomerController customerController;

        public ViewSalesForm(
            SaleController saleController,
            CarController carController,
            CustomerController customerController)
        {
            InitializeComponent();
            this.saleController = saleController;
            this.carController = carController;
            this.customerController = customerController;
        }

        private async void btnAllSales_Click(object sender, EventArgs e)
        {
            var sales = await saleController.GetAllSales();
            if (!sales.Any())
                txtResults.Text = "No sales found.";
            else
                txtResults.Text = string.Join(Environment.NewLine, sales.Select(s => $"Sale ID: {s.Id}, Car ID: {s.CarId}, Customer ID: {s.CustomerId}, Price: {s.Price:C}, Date: {s.Date:d}"));
        }

        private async void btnSalesByCarId_Click(object sender, EventArgs e)
        {
            int carId;
            if (!int.TryParse(txtCarId.Text, out carId))
            {
                MessageBox.Show("Enter a valid Car ID.");
                return;
            }
            var sales = await saleController.GetSalesByCarId(carId);
            if (!sales.Any())
                txtResults.Text = "No sales found for this Car.";
            else
                txtResults.Text = string.Join(Environment.NewLine, sales.Select(s => $"Sale ID: {s.Id}, Price: {s.Price:C}, Date: {s.Date:d}"));
        }

        private async void btnSalesByCustomerId_Click(object sender, EventArgs e)
        {
            int custId;
            if (!int.TryParse(txtCustomerId.Text, out custId))
            {
                MessageBox.Show("Enter a valid Customer ID.");
                return;
            }
            var sales = await saleController.GetSalesByCustomerId(custId);
            if (!sales.Any())
                txtResults.Text = "No sales found for this Customer.";
            else
                txtResults.Text = string.Join(Environment.NewLine, sales.Select(s => $"Sale ID: {s.Id}, Price: {s.Price:C}, Date: {s.Date:d}"));
        }
    }
}
