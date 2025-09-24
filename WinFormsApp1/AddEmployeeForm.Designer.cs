namespace AutoHouse.WinFormsApp
{
    partial class AddEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPosition;
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
            lblPosition = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPosition = new TextBox();
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
            lblFirstName.Paint += lblLastName_Paint;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = SystemColors.Control;
            lblLastName.Location = new Point(12, 55);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            lblLastName.Paint += lblLastName_Paint;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.ForeColor = SystemColors.Control;
            lblPosition.Location = new Point(12, 90);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(64, 20);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Position:";
            lblPosition.Paint += lblLastName_Paint;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = SystemColors.Control;
            lblPhone.Location = new Point(12, 125);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(92, 20);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone Num.:";
            lblPhone.Paint += lblLastName_Paint;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = SystemColors.Control;
            lblEmail.Location = new Point(12, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            lblEmail.Paint += lblLastName_Paint;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(105, 17);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(105, 52);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(105, 87);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(150, 27);
            txtPosition.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(105, 122);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(105, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 27);
            txtEmail.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(105, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddEmployeeForm
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(280, 250);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtPosition);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblPosition);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Employee";
            Load += AddEmployeeForm_Load;
            Paint += AddEmployeeForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
