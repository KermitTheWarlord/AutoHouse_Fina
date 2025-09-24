using System;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class AddCustomerForm : Form
    {
        private readonly CustomerController customerController;

        public AddCustomerForm(CustomerController customerController)
        {
            InitializeComponent();
            this.customerController = customerController;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (firstName == "" || lastName == "" || phone == "" || email == "")
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newCustomer = await customerController.AddCustomer(firstName, lastName, phone, email);
            MessageBox.Show($"Added Customer ID: {newCustomer.Id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomerForm_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkBlue;
        }
    }
}
