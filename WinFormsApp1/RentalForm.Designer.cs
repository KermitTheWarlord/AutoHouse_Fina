namespace AutoHouse.WinFormsApp
{
    partial class RentalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRent;

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
            lblCar = new System.Windows.Forms.Label();
            cmbCar = new System.Windows.Forms.ComboBox();
            lblCustomer = new System.Windows.Forms.Label();
            cmbCustomer = new System.Windows.Forms.ComboBox();
            lblStart = new System.Windows.Forms.Label();
            lblEnd = new System.Windows.Forms.Label();
            dtStart = new System.Windows.Forms.DateTimePicker();
            dtEnd = new System.Windows.Forms.DateTimePicker();
            btnCalculate = new System.Windows.Forms.Button();
            lblPricePerDay = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            btnRent = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new System.Drawing.Point(20, 20);
            lblCar.Name = "lblCar";
            lblCar.Size = new System.Drawing.Size(32, 20);
            lblCar.TabIndex = 0;
            lblCar.Text = "Car:";
            // 
            // cmbCar
            // 
            cmbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCar.FormattingEnabled = true;
            cmbCar.Location = new System.Drawing.Point(120, 17);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new System.Drawing.Size(220, 28);
            cmbCar.TabIndex = 1;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new System.Drawing.Point(20, 60);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(77, 20);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Customer:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new System.Drawing.Point(120, 57);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new System.Drawing.Size(220, 28);
            cmbCustomer.TabIndex = 3;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new System.Drawing.Point(20, 100);
            lblStart.Name = "lblStart";
            lblStart.Size = new System.Drawing.Size(73, 20);
            lblStart.TabIndex = 4;
            lblStart.Text = "Start Date:";
            // 
            // dtStart
            // 
            dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtStart.Location = new System.Drawing.Point(120, 97);
            dtStart.Name = "dtStart";
            dtStart.Size = new System.Drawing.Size(220, 27);
            dtStart.TabIndex = 5;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new System.Drawing.Point(20, 140);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new System.Drawing.Size(67, 20);
            lblEnd.TabIndex = 6;
            lblEnd.Text = "End Date:";
            // 
            // dtEnd
            // 
            dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtEnd.Location = new System.Drawing.Point(120, 137);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new System.Drawing.Size(220, 27);
            dtEnd.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(20, 180);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(150, 32);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Price";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblPricePerDay
            // 
            lblPricePerDay.AutoSize = true;
            lblPricePerDay.Location = new System.Drawing.Point(20, 225);
            lblPricePerDay.Name = "lblPricePerDay";
            lblPricePerDay.Size = new System.Drawing.Size(97, 20);
            lblPricePerDay.TabIndex = 9;
            lblPricePerDay.Text = "Price/Day: 0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(20, 255);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(59, 20);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total: 0";
            // 
            // btnRent
            // 
            btnRent.Location = new System.Drawing.Point(200, 180);
            btnRent.Name = "btnRent";
            btnRent.Size = new System.Drawing.Size(140, 32);
            btnRent.TabIndex = 11;
            btnRent.Text = "Confirm Rental";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // RentalForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkBlue;
            ClientSize = new System.Drawing.Size(370, 300);
            Controls.Add(btnRent);
            Controls.Add(lblTotal);
            Controls.Add(lblPricePerDay);
            Controls.Add(btnCalculate);
            Controls.Add(dtEnd);
            Controls.Add(lblEnd);
            Controls.Add(dtStart);
            Controls.Add(lblStart);
            Controls.Add(cmbCustomer);
            Controls.Add(lblCustomer);
            Controls.Add(cmbCar);
            Controls.Add(lblCar);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RentalForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Car Rental";
            Load += RentalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}