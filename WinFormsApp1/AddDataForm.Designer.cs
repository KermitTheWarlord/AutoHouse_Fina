namespace AutoHouse.WinFormsApp
{
    partial class AddDataForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddCar;
        private Button btnAddCustomer;
        private Button btnAddEmployee;
        private Button btnAddSale;

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
            btnAddCar = new Button();
            btnAddCustomer = new Button();
            btnAddEmployee = new Button();
            btnAddSale = new Button();
            SuspendLayout();
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(40, 20);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(180, 35);
            btnAddCar.TabIndex = 0;
            btnAddCar.Text = "Add Car";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            btnAddCar.Paint += btnAddCar_Paint;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(40, 65);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(180, 35);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(40, 110);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(180, 35);
            btnAddEmployee.TabIndex = 2;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(40, 155);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(180, 35);
            btnAddSale.TabIndex = 3;
            btnAddSale.Text = "Add Sale";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // AddDataForm
            // 
            ClientSize = new Size(264, 220);
            Controls.Add(btnAddSale);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnAddCar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Data";
            Load += AddDataForm_Load;
            Paint += AddDataForm_Paint;
            ResumeLayout(false);
        }
    }
}
