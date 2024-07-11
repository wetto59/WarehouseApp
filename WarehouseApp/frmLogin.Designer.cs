namespace WarehouseApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            TxtUser = new TextBox();
            TxtPass = new TextBox();
            label3 = new Label();
            BtnLogin = new Button();
            pictureBox2 = new PictureBox();
            Lbl_RegisterFrm = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 112);
            label1.Name = "label1";
            label1.Size = new Size(177, 35);
            label1.TabIndex = 0;
            label1.Text = "Welcome back";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 184);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // TxtUser
            // 
            TxtUser.BorderStyle = BorderStyle.None;
            TxtUser.Location = new Point(416, 210);
            TxtUser.Multiline = true;
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(245, 38);
            TxtUser.TabIndex = 3;
            // 
            // TxtPass
            // 
            TxtPass.BorderStyle = BorderStyle.None;
            TxtPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPass.Location = new Point(416, 285);
            TxtPass.Multiline = true;
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(245, 38);
            TxtPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 259);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(95, 61, 204);
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.ForeColor = Color.Transparent;
            BtnLogin.Location = new Point(416, 367);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(245, 48);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(450, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Lbl_RegisterFrm
            // 
            Lbl_RegisterFrm.AutoSize = true;
            Lbl_RegisterFrm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_RegisterFrm.Location = new Point(416, 326);
            Lbl_RegisterFrm.Name = "Lbl_RegisterFrm";
            Lbl_RegisterFrm.Size = new Size(146, 23);
            Lbl_RegisterFrm.TabIndex = 8;
            Lbl_RegisterFrm.Text = "Register Account";
            Lbl_RegisterFrm.Click += Lbl_RegisterFrm_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 243, 248);
            ClientSize = new Size(710, 427);
            Controls.Add(Lbl_RegisterFrm);
            Controls.Add(pictureBox2);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPass);
            Controls.Add(label3);
            Controls.Add(TxtUser);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox TxtPass;
        private Label label3;
        private Button BtnLogin;
        private PictureBox pictureBox2;
        private Label Lbl_RegisterFrm;
        public TextBox TxtUser;
    }
}