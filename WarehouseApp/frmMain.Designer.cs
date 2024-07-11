namespace WarehouseApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button BtnHome;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            BtnExit = new Button();
            BtnMaximize = new Button();
            BtnMinimize = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox9 = new PictureBox();
            BtnSupplier = new Button();
            pictureBox8 = new PictureBox();
            BtnUser = new Button();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            BtnSales = new Button();
            BtnCustomers = new Button();
            BtnPurchase = new Button();
            BtnProducts = new Button();
            BtnCateg = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            MainPanel = new Panel();
            BtnHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnHome
            // 
            BtnHome.BackColor = Color.Transparent;
            BtnHome.FlatAppearance.BorderSize = 0;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.ForeColor = Color.Transparent;
            BtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHome.Location = new Point(115, 171);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(99, 29);
            BtnHome.TabIndex = 0;
            BtnHome.Text = "Home";
            BtnHome.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.FromArgb(95, 61, 204);
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Segoe UI", 9F);
            BtnExit.ForeColor = Color.Transparent;
            BtnExit.Location = new Point(1273, 12);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(47, 26);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "X";
            BtnExit.TextAlign = ContentAlignment.TopCenter;
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnMaximize
            // 
            BtnMaximize.BackColor = Color.Silver;
            BtnMaximize.FlatAppearance.BorderSize = 0;
            BtnMaximize.FlatStyle = FlatStyle.Flat;
            BtnMaximize.Font = new Font("Segoe UI", 9F);
            BtnMaximize.ForeColor = Color.Transparent;
            BtnMaximize.Location = new Point(1220, 12);
            BtnMaximize.Name = "BtnMaximize";
            BtnMaximize.Size = new Size(47, 26);
            BtnMaximize.TabIndex = 1;
            BtnMaximize.Text = "🗖";
            BtnMaximize.TextAlign = ContentAlignment.TopCenter;
            BtnMaximize.UseVisualStyleBackColor = false;
            // 
            // BtnMinimize
            // 
            BtnMinimize.BackColor = Color.Silver;
            BtnMinimize.FlatAppearance.BorderSize = 0;
            BtnMinimize.FlatStyle = FlatStyle.Flat;
            BtnMinimize.Font = new Font("Segoe UI", 9F);
            BtnMinimize.ForeColor = Color.Transparent;
            BtnMinimize.Location = new Point(1167, 12);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(47, 26);
            BtnMinimize.TabIndex = 2;
            BtnMinimize.Text = "🗕";
            BtnMinimize.TextAlign = ContentAlignment.TopCenter;
            BtnMinimize.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnMinimize);
            panel1.Controls.Add(BtnMaximize);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 49);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(95, 61, 204);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(BtnSupplier);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(BtnUser);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnSales);
            panel2.Controls.Add(BtnCustomers);
            panel2.Controls.Add(BtnPurchase);
            panel2.Controls.Add(BtnProducts);
            panel2.Controls.Add(BtnCateg);
            panel2.Controls.Add(BtnHome);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 582);
            panel2.TabIndex = 4;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(26, 311);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(83, 49);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // BtnSupplier
            // 
            BtnSupplier.BackColor = Color.Transparent;
            BtnSupplier.FlatAppearance.BorderSize = 0;
            BtnSupplier.FlatStyle = FlatStyle.Flat;
            BtnSupplier.ForeColor = Color.Transparent;
            BtnSupplier.Location = new Point(115, 320);
            BtnSupplier.Name = "BtnSupplier";
            BtnSupplier.Size = new Size(99, 29);
            BtnSupplier.TabIndex = 13;
            BtnSupplier.Text = "Suppliers";
            BtnSupplier.UseVisualStyleBackColor = false;
            BtnSupplier.Click += BtnSupplier_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(26, 522);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(83, 48);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            // 
            // BtnUser
            // 
            BtnUser.BackColor = Color.Transparent;
            BtnUser.FlatAppearance.BorderSize = 0;
            BtnUser.FlatStyle = FlatStyle.Flat;
            BtnUser.ForeColor = Color.Transparent;
            BtnUser.Location = new Point(115, 532);
            BtnUser.Name = "BtnUser";
            BtnUser.Size = new Size(99, 29);
            BtnUser.TabIndex = 11;
            BtnUser.Text = "User";
            BtnUser.UseVisualStyleBackColor = false;
            BtnUser.Click += BtnUser_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(26, 470);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(83, 48);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(26, 416);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(83, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(26, 361);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(83, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 260);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(83, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(26, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // BtnSales
            // 
            BtnSales.BackColor = Color.Transparent;
            BtnSales.FlatAppearance.BorderSize = 0;
            BtnSales.FlatStyle = FlatStyle.Flat;
            BtnSales.ForeColor = Color.Transparent;
            BtnSales.Location = new Point(115, 479);
            BtnSales.Name = "BtnSales";
            BtnSales.Size = new Size(99, 29);
            BtnSales.TabIndex = 5;
            BtnSales.Text = "Sales";
            BtnSales.UseVisualStyleBackColor = false;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackColor = Color.Transparent;
            BtnCustomers.FlatAppearance.BorderSize = 0;
            BtnCustomers.FlatStyle = FlatStyle.Flat;
            BtnCustomers.ForeColor = Color.Transparent;
            BtnCustomers.Location = new Point(115, 425);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(99, 29);
            BtnCustomers.TabIndex = 4;
            BtnCustomers.Text = "Customers";
            BtnCustomers.UseVisualStyleBackColor = false;
            BtnCustomers.Click += BtnCustomers_Click;
            // 
            // BtnPurchase
            // 
            BtnPurchase.BackColor = Color.Transparent;
            BtnPurchase.FlatAppearance.BorderSize = 0;
            BtnPurchase.FlatStyle = FlatStyle.Flat;
            BtnPurchase.ForeColor = Color.Transparent;
            BtnPurchase.Location = new Point(115, 370);
            BtnPurchase.Name = "BtnPurchase";
            BtnPurchase.Size = new Size(99, 29);
            BtnPurchase.TabIndex = 3;
            BtnPurchase.Text = "Purchases";
            BtnPurchase.UseVisualStyleBackColor = false;
            BtnPurchase.Click += BtnPurchase_Click;
            // 
            // BtnProducts
            // 
            BtnProducts.BackColor = Color.Transparent;
            BtnProducts.FlatAppearance.BorderSize = 0;
            BtnProducts.FlatStyle = FlatStyle.Flat;
            BtnProducts.ForeColor = Color.Transparent;
            BtnProducts.Location = new Point(115, 269);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(99, 29);
            BtnProducts.TabIndex = 2;
            BtnProducts.Text = "Products";
            BtnProducts.UseVisualStyleBackColor = false;
            BtnProducts.Click += BtnProducts_Click;
            // 
            // BtnCateg
            // 
            BtnCateg.BackColor = Color.Transparent;
            BtnCateg.FlatAppearance.BorderSize = 0;
            BtnCateg.FlatStyle = FlatStyle.Flat;
            BtnCateg.ForeColor = Color.Transparent;
            BtnCateg.Location = new Point(115, 216);
            BtnCateg.Name = "BtnCateg";
            BtnCateg.Size = new Size(99, 38);
            BtnCateg.TabIndex = 1;
            BtnCateg.Text = "Category";
            BtnCateg.UseVisualStyleBackColor = false;
            BtnCateg.Click += BtnCateg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(62, 134);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.Location = new Point(256, 55);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1074, 527);
            MainPanel.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 582);
            Controls.Add(MainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMain";
            Text = "frmMain";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnExit;
        private Button BtnMaximize;
        private Button BtnMinimize;
        private Panel panel1;
        private Panel panel2;
        private Panel MainPanel;
        private Button BtnHome;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnSales;
        private Button BtnCustomers;
        private Button BtnPurchase;
        private Button BtnProducts;
        private Button BtnCateg;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button BtnUser;
        private PictureBox pictureBox9;
        private Button BtnSupplier;
    }
}