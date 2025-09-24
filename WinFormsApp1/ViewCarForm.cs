using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class ViewCarForm : Form
    {
        private readonly CarController carController;
        private readonly ServiceController serviceController;

        public ViewCarForm(CarController carController, ServiceController serviceController)
        {
            InitializeComponent();
            this.carController = carController;
            this.serviceController = serviceController;
        }

        private async void btnViewById_Click(object sender, EventArgs e)
        {
            int carId;
            if (!int.TryParse(txtCarId.Text, out carId))
            {
                MessageBox.Show("Please enter a valid Car ID.");
                return;
            }
            var car = await carController.GetCarById(carId);
            if (car == null)
                txtResults.Text = "Car not found.";
            else
                txtResults.Text = $"{car.Id}: {car.Make} {car.Model}, {car.Year}, {car.Price:C}";
        }

        private async void btnSearchByMake_Click(object sender, EventArgs e)
        {
            var make = txtMake.Text.Trim();
            if (string.IsNullOrWhiteSpace(make))
            {
                MessageBox.Show("Please enter a Make.");
                return;
            }
            var cars = await carController.GetCarsByMake(make);
            if (!cars.Any())
                txtResults.Text = "No cars found for this make.";
            else
                txtResults.Text = string.Join(Environment.NewLine, cars.Select(c => $"{c.Id}: {c.Make} {c.Model}, {c.Year}, {c.Price:C}"));
        }

        private async void btnCarsByServiceId_Click(object sender, EventArgs e)
        {
            int serviceId;
            if (!int.TryParse(txtServiceId.Text, out serviceId))
            {
                MessageBox.Show("Please enter a valid Service ID.");
                return;
            }
            var cars = await serviceController.GetCarsByService(serviceId);
            if (!cars.Any())
                txtResults.Text = "No cars found for this service.";
            else
                txtResults.Text = string.Join(Environment.NewLine, cars.Select(c => $"{c.Id}: {c.Make} {c.Model}, {c.Year}, {c.Price:C}"));
        }

        private async void btnCarsByPriceRange_Click(object sender, EventArgs e)
        {
            decimal min, max;
            if (!decimal.TryParse(txtMinPrice.Text, out min) || !decimal.TryParse(txtMaxPrice.Text, out max))
            {
                MessageBox.Show("Enter valid prices.");
                return;
            }
            var cars = await carController.GetCarsByPriceRange(min, max);
            if (!cars.Any())
                txtResults.Text = "No cars in this price range.";
            else
                txtResults.Text = string.Join(Environment.NewLine, cars.Select(c => $"{c.Id}: {c.Make} {c.Model}, {c.Year}, {c.Price:C}"));
        }
    }
}
