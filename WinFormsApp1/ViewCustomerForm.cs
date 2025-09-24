using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoHouse.Core;

namespace AutoHouse.WinFormsApp
{
    public partial class ViewCustomerForm : Form
    {
        private readonly CustomerController customerController;
        private readonly ServiceController serviceController;

        public ViewCustomerForm(CustomerController customerController, ServiceController serviceController)
        {
            InitializeComponent();
            this.customerController = customerController;
            this.serviceController = serviceController;
        }

        private async void btnViewById_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerId.Text, out customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }
            var cust = await customerController.GetCustomerById(customerId);
            if (cust == null)
                txtResults.Text = "Customer not found.";
            else
                txtResults.Text = $"{cust.Id}: {cust.FirstName} {cust.LastName}, {cust.PhoneNumber}, {cust.Email}";
        }

        private async void btnSearchByLastName_Click(object sender, EventArgs e)
        {
            var lastName = txtLastName.Text.Trim();
            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter a Last Name.");
                return;
            }
            var customers = await customerController.GetCustomersByLastName(lastName);
            if (!customers.Any())
                txtResults.Text = "No customers found.";
            else
                txtResults.Text = string.Join(Environment.NewLine, customers.Select(c => $"{c.Id}: {c.FirstName} {c.LastName}, {c.PhoneNumber}, {c.Email}"));
        }

        private async void btnSearchByDomain_Click(object sender, EventArgs e)
        {
            var domain = txtDomain.Text.Trim();
            if (string.IsNullOrWhiteSpace(domain))
            {
                MessageBox.Show("Please enter an Email Domain.");
                return;
            }
            var customers = await customerController.GetCustomersByEmailDomain(domain);
            if (!customers.Any())
                txtResults.Text = "No customers found for this domain.";
            else
                txtResults.Text = string.Join(Environment.NewLine, customers.Select(c => $"{c.Id}: {c.FirstName} {c.LastName}, {c.Email}"));
        }

        private async void btnServicesByCustomerId_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerIdForServices.Text, out customerId))
            {
                MessageBox.Show("Enter a valid Customer ID.");
                return;
            }
            var services = await serviceController.GetServicesByCustomer(customerId);
            if (!services.Any())
                txtResults.Text = "No services found for this customer.";
            else
                txtResults.Text = string.Join(Environment.NewLine, services.Select(s => $"{s.Id}: {s.Name}"));
        }
    }
}
