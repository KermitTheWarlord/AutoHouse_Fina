namespace AutoHouse.WinFormsApp
{
    partial class AddCarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPrice;
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
            lblMake = new Label();
            lblModel = new Label();
            lblYear = new Label();
            lblPrice = new Label();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(15, 25);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(48, 20);
            lblMake.TabIndex = 0;
            lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(15, 75);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(55, 20);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(15, 125);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 20);
            lblYear.TabIndex = 2;
            lblYear.Text = "Year:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(15, 175);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            lblPrice.Click += lblPrice_Click;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(80, 21);
            txtMake.Margin = new Padding(3, 4, 3, 4);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(150, 27);
            txtMake.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(80, 71);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 27);
            txtModel.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(80, 121);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 27);
            txtYear.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(80, 171);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 27);
            txtPrice.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(80, 219);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 38);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Car";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(260, 288);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(lblPrice);
            Controls.Add(lblYear);
            Controls.Add(lblModel);
            Controls.Add(lblMake);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AddCarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Car";
            Load += AddCarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
