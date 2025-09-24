namespace AutoHouse.WinFormsApp
{
    partial class ViewEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnViewById;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnSearchByPosition;
        private System.Windows.Forms.Label lblEmployeeIdForServices;
        private System.Windows.Forms.TextBox txtEmployeeIdForServices;
        private System.Windows.Forms.Button btnServicesByEmployeeId;
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
            lblEmployeeId = new Label();
            txtEmployeeId = new TextBox();
            btnViewById = new Button();
            lblPosition = new Label();
            txtPosition = new TextBox();
            btnSearchByPosition = new Button();
            lblEmployeeIdForServices = new Label();
            txtEmployeeIdForServices = new TextBox();
            btnServicesByEmployeeId = new Button();
            txtResults = new TextBox();
            SuspendLayout();
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.ForeColor = SystemColors.Control;
            lblEmployeeId.Location = new Point(15, 15);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(97, 20);
            lblEmployeeId.TabIndex = 0;
            lblEmployeeId.Text = "Employee ID:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(110, 12);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(70, 27);
            txtEmployeeId.TabIndex = 1;
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
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.ForeColor = SystemColors.Control;
            lblPosition.Location = new Point(15, 50);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(64, 20);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position:";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(110, 47);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(70, 27);
            txtPosition.TabIndex = 4;
            // 
            // btnSearchByPosition
            // 
            btnSearchByPosition.Location = new Point(190, 45);
            btnSearchByPosition.Name = "btnSearchByPosition";
            btnSearchByPosition.Size = new Size(120, 26);
            btnSearchByPosition.TabIndex = 5;
            btnSearchByPosition.Text = "Search by Position";
            btnSearchByPosition.UseVisualStyleBackColor = true;
            btnSearchByPosition.Click += btnSearchByPosition_Click;
            // 
            // lblEmployeeIdForServices
            // 
            lblEmployeeIdForServices.AutoSize = true;
            lblEmployeeIdForServices.ForeColor = SystemColors.Control;
            lblEmployeeIdForServices.Location = new Point(15, 85);
            lblEmployeeIdForServices.Name = "lblEmployeeIdForServices";
            lblEmployeeIdForServices.Size = new Size(97, 20);
            lblEmployeeIdForServices.TabIndex = 6;
            lblEmployeeIdForServices.Text = "Employee ID:";
            // 
            // txtEmployeeIdForServices
            // 
            txtEmployeeIdForServices.Location = new Point(110, 82);
            txtEmployeeIdForServices.Name = "txtEmployeeIdForServices";
            txtEmployeeIdForServices.Size = new Size(70, 27);
            txtEmployeeIdForServices.TabIndex = 7;
            // 
            // btnServicesByEmployeeId
            // 
            btnServicesByEmployeeId.Location = new Point(190, 80);
            btnServicesByEmployeeId.Name = "btnServicesByEmployeeId";
            btnServicesByEmployeeId.Size = new Size(120, 26);
            btnServicesByEmployeeId.TabIndex = 8;
            btnServicesByEmployeeId.Text = "Services by Emp.";
            btnServicesByEmployeeId.UseVisualStyleBackColor = true;
            btnServicesByEmployeeId.Click += btnServicesByEmployeeId_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = SystemColors.ButtonShadow;
            txtResults.Location = new Point(15, 120);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(295, 120);
            txtResults.TabIndex = 9;
            // 
            // ViewEmployeeForm
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(330, 260);
            Controls.Add(txtResults);
            Controls.Add(btnServicesByEmployeeId);
            Controls.Add(txtEmployeeIdForServices);
            Controls.Add(lblEmployeeIdForServices);
            Controls.Add(btnSearchByPosition);
            Controls.Add(txtPosition);
            Controls.Add(lblPosition);
            Controls.Add(btnViewById);
            Controls.Add(txtEmployeeId);
            Controls.Add(lblEmployeeId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ViewEmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Employees";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
