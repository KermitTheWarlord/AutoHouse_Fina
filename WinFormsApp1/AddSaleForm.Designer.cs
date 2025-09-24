namespace AutoHouse.WinFormsApp
{
    partial class AddSaleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtSaleDate;
        private System.Windows.Forms.Button btnAdd;

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
            lblCarId = new Label();
            lblCustomerId = new Label();
            lblEmployeeId = new Label();
            lblPrice = new Label();
            lblSaleDate = new Label();
            txtCarId = new TextBox();
            txtCustomerId = new TextBox();
            txtEmployeeId = new TextBox();
            txtPrice = new TextBox();
            dtSaleDate = new DateTimePicker();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblCarId
            // 
            lblCarId.AutoSize = true;
            lblCarId.ForeColor = SystemColors.Control;
            lblCarId.Location = new Point(12, 20);
            lblCarId.Name = "lblCarId";
            lblCarId.Size = new Size(53, 20);
            lblCarId.TabIndex = 0;
            lblCarId.Text = "Car ID:";
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.ForeColor = SystemColors.Control;
            lblCustomerId.Location = new Point(12, 64);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(94, 20);
            lblCustomerId.TabIndex = 1;
            lblCustomerId.Text = "Customer ID:";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.ForeColor = SystemColors.Control;
            lblEmployeeId.Location = new Point(12, 100);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(97, 20);
            lblEmployeeId.TabIndex = 2;
            lblEmployeeId.Text = "Employee ID:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.ForeColor = SystemColors.Control;
            lblPrice.Location = new Point(12, 140);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblSaleDate
            // 
            lblSaleDate.AutoSize = true;
            lblSaleDate.ForeColor = SystemColors.Control;
            lblSaleDate.Location = new Point(12, 180);
            lblSaleDate.Name = "lblSaleDate";
            lblSaleDate.Size = new Size(76, 20);
            lblSaleDate.TabIndex = 4;
            lblSaleDate.Text = "Sale Date:";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(110, 17);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(150, 27);
            txtCarId.TabIndex = 5;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(110, 57);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(150, 27);
            txtCustomerId.TabIndex = 6;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(110, 97);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(150, 27);
            txtEmployeeId.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(110, 137);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 27);
            txtPrice.TabIndex = 8;
            // 
            // dtSaleDate
            // 
            dtSaleDate.Format = DateTimePickerFormat.Short;
            dtSaleDate.Location = new Point(110, 177);
            dtSaleDate.Name = "dtSaleDate";
            dtSaleDate.Size = new Size(150, 27);
            dtSaleDate.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(110, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Sale";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddSaleForm
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(285, 270);
            Controls.Add(btnAdd);
            Controls.Add(dtSaleDate);
            Controls.Add(txtPrice);
            Controls.Add(txtEmployeeId);
            Controls.Add(txtCustomerId);
            Controls.Add(txtCarId);
            Controls.Add(lblSaleDate);
            Controls.Add(lblPrice);
            Controls.Add(lblEmployeeId);
            Controls.Add(lblCustomerId);
            Controls.Add(lblCarId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddSaleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Sale";
            Load += AddSaleForm_Load;
            Paint += AddSaleForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
