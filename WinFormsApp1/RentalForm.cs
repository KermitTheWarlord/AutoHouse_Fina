using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class RentalForm : Form
    {
        private readonly AutoHouse.Data.AutoHouseDbContext dbContext;
        private readonly CarController carController;
        private readonly CustomerController customerController;

        public RentalForm(
            AutoHouse.Data.AutoHouseDbContext dbContext,
            CarController carController,
            CustomerController customerController)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.carController = carController;
            this.customerController = customerController;
        }

        private async void RentalForm_Load(object sender, EventArgs e)
        {
            // Populate cars dropdown
            var cars = await carController.GetCarsByMake(""); // get all cars
            cmbCar.Items.Clear();
            foreach (var car in cars)
            {
                cmbCar.Items.Add($"{car.Id}: {car.Make} {car.Model} ({car.Year}) - {car.Price:C}");
            }

            // Populate customers dropdown
            var customers = await customerController.GetCustomersByLastName(""); // get all customers
            cmbCustomer.Items.Clear();
            foreach (var cust in customers)
            {
                cmbCustomer.Items.Add($"{cust.Id}: {cust.FirstName} {cust.LastName}");
            }
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbCar.SelectedIndex == -1) { MessageBox.Show("Select a car."); return; }
            if (cmbCustomer.SelectedIndex == -1) { MessageBox.Show("Select a customer."); return; }
            if (dtEnd.Value.Date < dtStart.Value.Date) { MessageBox.Show("End date must be after start date."); return; }

            int carId = int.Parse(cmbCar.SelectedItem.ToString().Split(':')[0]);
            var car = await carController.GetCarById(carId);
            if (car == null) { MessageBox.Show("Invalid car."); return; }

            int days = (dtEnd.Value.Date - dtStart.Value.Date).Days + 1;
            decimal pricePerDay = car.Price * 0.10m;
            decimal total = pricePerDay * days;

            lblPricePerDay.Text = $"Price/Day: {pricePerDay:C}";
            lblTotal.Text = $"Total: {total:C}";
        }

        private async void btnRent_Click(object sender, EventArgs e)
        {
            if (cmbCar.SelectedIndex == -1) { MessageBox.Show("Select a car."); return; }
            if (cmbCustomer.SelectedIndex == -1) { MessageBox.Show("Select a customer."); return; }

            int carId = int.Parse(cmbCar.SelectedItem.ToString().Split(':')[0]);
            int custId = int.Parse(cmbCustomer.SelectedItem.ToString().Split(':')[0]);
            DateTime start = dtStart.Value.Date;
            DateTime end = dtEnd.Value.Date;

            var rentalController = new RentalController(dbContext);
            try
            {
                var rental = await rentalController.AddRental(carId, custId, start, end);
                MessageBox.Show($"Rental created! Total: {rental.TotalPrice:C}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}