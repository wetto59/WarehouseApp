namespace WarehouseApp
{
    partial class SampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            BtnAdd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 40);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "Sample Header";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 40);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(BtnAdd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 147);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(420, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(95, 61, 204);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0, true);
            textBox1.Location = new Point(411, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Here";
            textBox1.Size = new Size(361, 39);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(95, 61, 204);
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.ForeColor = Color.Transparent;
            BtnAdd.ImageAlign = ContentAlignment.TopLeft;
            BtnAdd.Location = new Point(77, 74);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(127, 39);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Add New";
            BtnAdd.TextAlign = ContentAlignment.MiddleRight;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += button1_Click;
            // 
            // SampleView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SampleView";
            Text = "SampleView";
            Load += SampleView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label label1;
        public Label label2;
        public Panel panel1;
        public TextBox textBox1;
        public Button BtnAdd;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2;
    }
}