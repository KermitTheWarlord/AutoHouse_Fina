namespace AutoHouse.WinFormsApp
{
    partial class ViewCarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Button btnViewById;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnSearchByMake;
        private System.Windows.Forms.Label lblServiceId;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Button btnCarsByServiceId;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Button btnCarsByPriceRange;
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
            lblCarId = new Label();
            txtCarId = new TextBox();
            btnViewById = new Button();
            lblMake = new Label();
            txtMake = new TextBox();
            btnSearchByMake = new Button();
            lblServiceId = new Label();
            txtServiceId = new TextBox();
            btnCarsByServiceId = new Button();
            lblMinPrice = new Label();
            lblMaxPrice = new Label();
            txtMinPrice = new TextBox();
            txtMaxPrice = new TextBox();
            btnCarsByPriceRange = new Button();
            txtResults = new TextBox();
            SuspendLayout();
            // 
            // lblCarId
            // 
            lblCarId.AutoSize = true;
            lblCarId.Location = new Point(15, 15);
            lblCarId.Name = "lblCarId";
            lblCarId.Size = new Size(53, 20);
            lblCarId.TabIndex = 0;
            lblCarId.Text = "Car ID:";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(70, 12);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(70, 27);
            txtCarId.TabIndex = 1;
            // 
            // btnViewById
            // 
            btnViewById.ForeColor = SystemColors.ControlText;
            btnViewById.Location = new Point(150, 10);
            btnViewById.Name = "btnViewById";
            btnViewById.Size = new Size(120, 26);
            btnViewById.TabIndex = 2;
            btnViewById.Text = "View by ID";
            btnViewById.UseVisualStyleBackColor = true;
            btnViewById.Click += btnViewById_Click;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(15, 50);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(48, 20);
            lblMake.TabIndex = 3;
            lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(70, 47);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(70, 27);
            txtMake.TabIndex = 4;
            // 
            // btnSearchByMake
            // 
            btnSearchByMake.ForeColor = SystemColors.ControlText;
            btnSearchByMake.Location = new Point(150, 45);
            btnSearchByMake.Name = "btnSearchByMake";
            btnSearchByMake.Size = new Size(120, 26);
            btnSearchByMake.TabIndex = 5;
            btnSearchByMake.Text = "Search by Make";
            btnSearchByMake.UseVisualStyleBackColor = true;
            btnSearchByMake.Click += btnSearchByMake_Click;
            // 
            // lblServiceId
            // 
            lblServiceId.AutoSize = true;
            lblServiceId.Location = new Point(15, 85);
            lblServiceId.Name = "lblServiceId";
            lblServiceId.Size = new Size(78, 20);
            lblServiceId.TabIndex = 6;
            lblServiceId.Text = "Service ID:";
            // 
            // txtServiceId
            // 
            txtServiceId.Location = new Point(90, 82);
            txtServiceId.Name = "txtServiceId";
            txtServiceId.Size = new Size(50, 27);
            txtServiceId.TabIndex = 7;
            // 
            // btnCarsByServiceId
            // 
            btnCarsByServiceId.ForeColor = SystemColors.ControlText;
            btnCarsByServiceId.Location = new Point(150, 80);
            btnCarsByServiceId.Name = "btnCarsByServiceId";
            btnCarsByServiceId.Size = new Size(120, 26);
            btnCarsByServiceId.TabIndex = 8;
            btnCarsByServiceId.Text = "By Service ID";
            btnCarsByServiceId.UseVisualStyleBackColor = true;
            btnCarsByServiceId.Click += btnCarsByServiceId_Click;
            // 
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.Location = new Point(15, 120);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(73, 20);
            lblMinPrice.TabIndex = 9;
            lblMinPrice.Text = "Min Price:";
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Location = new Point(150, 120);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(76, 20);
            lblMaxPrice.TabIndex = 11;
            lblMaxPrice.Text = "Max Price:";
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(90, 117);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(50, 27);
            txtMinPrice.TabIndex = 10;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(225, 117);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(50, 27);
            txtMaxPrice.TabIndex = 12;
            // 
            // btnCarsByPriceRange
            // 
            btnCarsByPriceRange.ForeColor = SystemColors.ControlText;
            btnCarsByPriceRange.Location = new Point(15, 150);
            btnCarsByPriceRange.Name = "btnCarsByPriceRange";
            btnCarsByPriceRange.Size = new Size(260, 26);
            btnCarsByPriceRange.TabIndex = 13;
            btnCarsByPriceRange.Text = "Cars by Price Range";
            btnCarsByPriceRange.UseVisualStyleBackColor = true;
            btnCarsByPriceRange.Click += btnCarsByPriceRange_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = SystemColors.ButtonShadow;
            txtResults.Location = new Point(15, 198);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(260, 120);
            txtResults.TabIndex = 14;
            // 
            // ViewCarForm
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(290, 330);
            Controls.Add(txtResults);
            Controls.Add(btnCarsByPriceRange);
            Controls.Add(txtMaxPrice);
            Controls.Add(lblMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(lblMinPrice);
            Controls.Add(btnCarsByServiceId);
            Controls.Add(txtServiceId);
            Controls.Add(lblServiceId);
            Controls.Add(btnSearchByMake);
            Controls.Add(txtMake);
            Controls.Add(lblMake);
            Controls.Add(btnViewById);
            Controls.Add(txtCarId);
            Controls.Add(lblCarId);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ViewCarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Cars";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
