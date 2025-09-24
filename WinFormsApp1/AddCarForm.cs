using System;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class AddCarForm : Form
    {
        private readonly CarController carController;

        public AddCarForm(CarController carController)
        {
            InitializeComponent();
            this.carController = carController;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string make = txtMake.Text.Trim();
            string model = txtModel.Text.Trim();
            int year;
            decimal price;

            if (make == "" || model == "" || !int.TryParse(txtYear.Text, out year) || !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid values for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newCar = await carController.AddCar(make, model, year, price);
            MessageBox.Show($"Added Car ID: {newCar.Id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
