namespace AutoHouse.WinFormsApp
{
    partial class AddCustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = SystemColors.Control;
            lblFirstName.Location = new Point(12, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = SystemColors.Control;
            lblLastName.Location = new Point(12, 60);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = SystemColors.Control;
            lblPhone.Location = new Point(12, 100);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(92, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Num.:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = SystemColors.Control;
            lblEmail.Location = new Point(12, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(100, 17);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(100, 57);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(100, 97);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(100, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddCustomerForm
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(280, 230);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Customer";
            Load += AddCustomerForm_Load;
            Paint += AddCustomerForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
