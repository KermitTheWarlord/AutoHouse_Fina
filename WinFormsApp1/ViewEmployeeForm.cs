using System;
using System.Linq;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class ViewEmployeeForm : Form
    {
        private readonly EmployeeController employeeController;
        private readonly ServiceController serviceController;

        public ViewEmployeeForm(EmployeeController employeeController, ServiceController serviceController)
        {
            InitializeComponent();
            this.employeeController = employeeController;
            this.serviceController = serviceController;
        }

        private async void btnViewById_Click(object sender, EventArgs e)
        {
            int empId;
            if (!int.TryParse(txtEmployeeId.Text, out empId))
            {
                MessageBox.Show("Please enter a valid Employee ID.");
                return;
            }
            var emp = await employeeController.GetEmployeeById(empId);
            if (emp == null)
                txtResults.Text = "Employee not found.";
            else
            
                txtResults.Text = $"{emp.Id}: {emp.FirstName} {emp.LastName}, {emp.Position}, {emp.PhoneNumber}, {emp.Email}";

        }

        private async void btnSearchByPosition_Click(object sender, EventArgs e)
        {
            var pos = txtPosition.Text.Trim();
            if (string.IsNullOrWhiteSpace(pos))
            {
                MessageBox.Show("Please enter a Position.");
                return;
            }
            var employees = await employeeController.GetEmployeesByPosition(pos);
            if (!employees.Any())
                txtResults.Text = "No employees found for this position.";
            else
                txtResults.Text = string.Join(Environment.NewLine, employees.Select(emp => $"{emp.Id}: {emp.FirstName} {emp.LastName}, {emp.Position}, {emp.PhoneNumber}, {emp.Email}"));

        }

        private async void btnServicesByEmployeeId_Click(object sender, EventArgs e)
        {
            int empId;
            if (!int.TryParse(txtEmployeeIdForServices.Text, out empId))
            {
                MessageBox.Show("Enter a valid Employee ID.");
                return;
            }
            var services = await serviceController.GetServicesByEmployee(empId);
            if (!services.Any())
                txtResults.Text = "No services found for this employee.";
            else
                txtResults.Text = string.Join(Environment.NewLine, services.Select(s => $"{s.Id}: {s.Name}"));
        }
    }
}
