namespace AutoHouse.WinFormsApp
{
    partial class ViewSalesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAllSales;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Button btnSalesByCarId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnSalesByCustomerId;
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
            btnAllSales = new Button();
            lblCarId = new Label();
            txtCarId = new TextBox();
            btnSalesByCarId = new Button();
            lblCustomerId = new Label();
            txtCustomerId = new TextBox();
            btnSalesByCustomerId = new Button();
            txtResults = new TextBox();
            SuspendLayout();
            // 
            // btnAllSales
            // 
            btnAllSales.Location = new Point(15, 15);
            btnAllSales.Name = "btnAllSales";
            btnAllSales.Size = new Size(260, 30);
            btnAllSales.TabIndex = 0;
            btnAllSales.Text = "Show All Sales";
            btnAllSales.UseVisualStyleBackColor = true;
            btnAllSales.Click += btnAllSales_Click;
            // 
            // lblCarId
            // 
            lblCarId.AutoSize = true;
            lblCarId.ForeColor = SystemColors.Control;
            lblCarId.Location = new Point(15, 60);
            lblCarId.Name = "lblCarId";
            lblCarId.Size = new Size(53, 20);
            lblCarId.TabIndex = 1;
            lblCarId.Text = "Car ID:";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(80, 57);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(50, 27);
            txtCarId.TabIndex = 2;
            // 
            // btnSalesByCarId
            // 
            btnSalesByCarId.Location = new Point(150, 55);
            btnSalesByCarId.Name = "btnSalesByCarId";
            btnSalesByCarId.Size = new Size(125, 26);
            btnSalesByCarId.TabIndex = 3;
            btnSalesByCarId.Text = "Sales by Car";
            btnSalesByCarId.UseVisualStyleBackColor = true;
            btnSalesByCarId.Click += btnSalesByCarId_Click;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.ForeColor = SystemColors.Control;
            lblCustomerId.Location = new Point(15, 95);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(94, 20);
            lblCustomerId.TabIndex = 4;
            lblCustomerId.Text = "Customer ID:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(110, 92);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(50, 27);
            txtCustomerId.TabIndex = 5;
            // 
            // btnSalesByCustomerId
            // 
            btnSalesByCustomerId.Location = new Point(180, 90);
            btnSalesByCustomerId.Name = "btnSalesByCustomerId";
            btnSalesByCustomerId.Size = new Size(95, 26);
            btnSalesByCustomerId.TabIndex = 6;
            btnSalesByCustomerId.Text = "Sales by Cust.";
            btnSalesByCustomerId.UseVisualStyleBackColor = true;
            btnSalesByCustomerId.Click += btnSalesByCustomerId_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = SystemColors.ControlDark;
            txtResults.Location = new Point(15, 130);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(260, 120);
            txtResults.TabIndex = 7;
            // 
            // ViewSalesForm
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(295, 270);
            Controls.Add(txtResults);
            Controls.Add(btnSalesByCustomerId);
            Controls.Add(txtCustomerId);
            Controls.Add(lblCustomerId);
            Controls.Add(btnSalesByCarId);
            Controls.Add(txtCarId);
            Controls.Add(lblCarId);
            Controls.Add(btnAllSales);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ViewSalesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Sales";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
