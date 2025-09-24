namespace AutoHouse.WinFormsApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddData;
        private Button btnViewData;
        private Button btnRentals; // NEW BUTTON
        private PictureBox pictureBox1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnAddData = new Button();
            btnViewData = new Button();
            btnRentals = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddData
            // 
            btnAddData.Location = new Point(90, 84);
            btnAddData.Margin = new Padding(3, 4, 3, 4);
            btnAddData.Name = "btnAddData";
            btnAddData.Size = new Size(150, 50);
            btnAddData.TabIndex = 0;
            btnAddData.Text = "Add Data";
            btnAddData.UseVisualStyleBackColor = true;
            btnAddData.Click += btnAddData_Click;
            // 
            // btnViewData
            // 
            btnViewData.Location = new Point(90, 142);
            btnViewData.Margin = new Padding(3, 4, 3, 4);
            btnViewData.Name = "btnViewData";
            btnViewData.Size = new Size(150, 50);
            btnViewData.TabIndex = 1;
            btnViewData.Text = "View Data";
            btnViewData.UseVisualStyleBackColor = true;
            btnViewData.Click += btnViewData_Click;
            // 
            // btnRentals
            // 
            btnRentals.Location = new Point(90, 200);
            btnRentals.Margin = new Padding(3, 4, 3, 4);
            btnRentals.Name = "btnRentals";
            btnRentals.Size = new Size(150, 50);
            btnRentals.TabIndex = 2;
            btnRentals.Text = "Rentals";
            btnRentals.UseVisualStyleBackColor = true;
            btnRentals.Click += btnRentals_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 55);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(325, 280);
            Controls.Add(pictureBox1);
            Controls.Add(btnRentals);
            Controls.Add(btnViewData);
            Controls.Add(btnAddData);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoHouse Main Menu";
            Load += MainForm_Load;
            BackgroundImageChanged += MainForm_BackgroundImageChanged;
            Paint += MainForm_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }
    }
}