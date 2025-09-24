using System;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class AddEmployeeForm : Form
    {
        private readonly EmployeeController employeeController;

        public AddEmployeeForm(EmployeeController employeeController)
        {
            InitializeComponent();
            this.employeeController = employeeController;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (firstName == "" || lastName == "" || position == "" || phone == "" || email == "")
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newEmployee = await employeeController.AddEmployee(firstName, lastName, position, phone, email);
            MessageBox.Show($"Added Employee ID: {newEmployee.Id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void AddEmployeeForm_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkBlue;

        }

        private void lblLastName_Paint(object sender, PaintEventArgs e)
        {
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
