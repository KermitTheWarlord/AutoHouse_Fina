namespace AutoHouse.WinFormsApp
{
    partial class ViewCustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnViewById;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSearchByLastName;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnSearchByDomain;
        private System.Windows.Forms.Label lblCustomerIdForServices;
        private System.Windows.Forms.TextBox txtCustomerIdForServices;
        private System.Windows.Forms.Button btnServicesByCustomerId;
        private System.Windows.Forms.TextBox txtResults;

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
            lblCustomerId = new Label();
            txtCustomerId = new TextBox();
            btnViewById = new Button();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnSearchByLastName = new Button();
            lblDomain = new Label();
            txtDomain = new TextBox();
            btnSearchByDomain = new Button();
            lblCustomerIdForServices = new Label();
            txtCustomerIdForServices = new TextBox();
            btnServicesByCustomerId = new Button();
            txtResults = new TextBox();
            SuspendLayout();
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.ForeColor = SystemColors.Control;
            lblCustomerId.Location = new Point(15, 15);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(94, 20);
            lblCustomerId.TabIndex = 0;
            lblCustomerId.Text = "Customer ID:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(110, 12);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(70, 27);
            txtCustomerId.TabIndex = 1;
            // 
            // btnViewById
            // 
            btnViewById.Location = new Point(190, 10);
            btnViewById.Name = "btnViewById";
            btnViewById.Size = new Size(120, 26);
            btnViewById.TabIndex = 2;
            btnViewById.Text = "View by ID";
            btnViewById.UseVisualStyleBackColor = true;
            btnViewById.Click += btnViewById_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = SystemColors.Control;
            lblLastName.Location = new Point(15, 50);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(110, 47);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(70, 27);
            txtLastName.TabIndex = 4;
            // 
            // btnSearchByLastName
            // 
            btnSearchByLastName.Location = new Point(190, 45);
            btnSearchByLastName.Name = "btnSearchByLastName";
            btnSearchByLastName.Size = new Size(120, 26);
            btnSearchByLastName.TabIndex = 5;
            btnSearchByLastName.Text = "Search by Name";
            btnSearchByLastName.UseVisualStyleBackColor = true;
            btnSearchByLastName.Click += btnSearchByLastName_Click;
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.ForeColor = SystemColors.Control;
            lblDomain.Location = new Point(15, 85);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(65, 20);
            lblDomain.TabIndex = 6;
            lblDomain.Text = "Domain:";
            // 
            // txtDomain
            // 
            txtDomain.Location = new Point(110, 82);
            txtDomain.Name = "txtDomain";
            txtDomain.Size = new Size(70, 27);
            txtDomain.TabIndex = 7;
            // 
            // btnSearchByDomain
            // 
            btnSearchByDomain.Location = new Point(190, 80);
            btnSearchByDomain.Name = "btnSearchByDomain";
            btnSearchByDomain.Size = new Size(120, 26);
            btnSearchByDomain.TabIndex = 8;
            btnSearchByDomain.Text = "By Email Domain";
            btnSearchByDomain.UseVisualStyleBackColor = true;
            btnSearchByDomain.Click += btnSearchByDomain_Click;
            // 
            // lblCustomerIdForServices
            // 
            lblCustomerIdForServices.AutoSize = true;
            lblCustomerIdForServices.ForeColor = SystemColors.Control;
            lblCustomerIdForServices.Location = new Point(15, 120);
            lblCustomerIdForServices.Name = "lblCustomerIdForServices";
            lblCustomerIdForServices.Size = new Size(94, 20);
            lblCustomerIdForServices.TabIndex = 9;
            lblCustomerIdForServices.Text = "Customer ID:";
            // 
            // txtCustomerIdForServices
            // 
            txtCustomerIdForServices.Location = new Point(110, 117);
            txtCustomerIdForServices.Name = "txtCustomerIdForServices";
            txtCustomerIdForServices.Size = new Size(70, 27);
            txtCustomerIdForServices.TabIndex = 10;
            // 
            // btnServicesByCustomerId
            // 
            btnServicesByCustomerId.Location = new Point(190, 115);
            btnServicesByCustomerId.Name = "btnServicesByCustomerId";
            btnServicesByCustomerId.Size = new Size(120, 26);
            btnServicesByCustomerId.TabIndex = 11;
            btnServicesByCustomerId.Text = "Services by Cust.";
            btnServicesByCustomerId.UseVisualStyleBackColor = true;
            btnServicesByCustomerId.Click += btnServicesByCustomerId_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = SystemColors.ButtonShadow;
            txtResults.Location = new Point(15, 160);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(295, 120);
            txtResults.TabIndex = 12;
            // 
            // ViewCustomerForm
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(330, 300);
            Controls.Add(txtResults);
            Controls.Add(btnServicesByCustomerId);
            Controls.Add(txtCustomerIdForServices);
            Controls.Add(lblCustomerIdForServices);
            Controls.Add(btnSearchByDomain);
            Controls.Add(txtDomain);
            Controls.Add(lblDomain);
            Controls.Add(btnSearchByLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(btnViewById);
            Controls.Add(txtCustomerId);
            Controls.Add(lblCustomerId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ViewCustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Customers";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
