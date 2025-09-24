namespace AutoHouse.WinFormsApp
{
    partial class ViewDataForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSales;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCars = new Button();
            btnCustomers = new Button();
            btnEmployees = new Button();
            btnSales = new Button();
            SuspendLayout();
            // 
            // btnCars
            // 
            btnCars.Location = new Point(40, 20);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(180, 35);
            btnCars.TabIndex = 0;
            btnCars.Text = "View Cars";
            btnCars.UseVisualStyleBackColor = true;
            btnCars.Click += btnCars_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(40, 65);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(180, 35);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "View Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(40, 110);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(180, 35);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "View Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(40, 155);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(180, 35);
            btnSales.TabIndex = 3;
            btnSales.Text = "View Sales & Reports";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // ViewDataForm
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(264, 220);
            Controls.Add(btnSales);
            Controls.Add(btnEmployees);
            Controls.Add(btnCustomers);
            Controls.Add(btnCars);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ViewDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Data";
            ResumeLayout(false);
        }
    }
}
