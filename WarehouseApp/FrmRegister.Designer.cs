namespace WarehouseApp
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            pictureBox1 = new PictureBox();
            TxtUser = new TextBox();
            TxtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TxtPass = new TextBox();
            BtnReg = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(360, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TxtUser
            // 
            TxtUser.BorderStyle = BorderStyle.None;
            TxtUser.Location = new Point(27, 83);
            TxtUser.Multiline = true;
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(229, 30);
            TxtUser.TabIndex = 1;
            // 
            // TxtPhone
            // 
            TxtPhone.BorderStyle = BorderStyle.None;
            TxtPhone.Location = new Point(27, 229);
            TxtPhone.Multiline = true;
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(229, 30);
            TxtPhone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 35);
            label1.TabIndex = 3;
            label1.Text = "Create an account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 57);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 203);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 5;
            label3.Text = "Phone number:";
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.Location = new Point(27, 151);
            TxtEmail.Multiline = true;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(229, 30);
            TxtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 125);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 270);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 8;
            label5.Text = "Password:";
            // 
            // TxtPass
            // 
            TxtPass.BorderStyle = BorderStyle.None;
            TxtPass.Location = new Point(27, 296);
            TxtPass.Multiline = true;
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(229, 30);
            TxtPass.TabIndex = 9;
            // 
            // BtnReg
            // 
            BtnReg.BackColor = Color.FromArgb(95, 61, 204);
            BtnReg.FlatAppearance.BorderSize = 0;
            BtnReg.FlatStyle = FlatStyle.Flat;
            BtnReg.ForeColor = Color.Transparent;
            BtnReg.Location = new Point(38, 346);
            BtnReg.Name = "BtnReg";
            BtnReg.Size = new Size(201, 42);
            BtnReg.TabIndex = 10;
            BtnReg.Text = "Register";
            BtnReg.UseVisualStyleBackColor = false;
            BtnReg.Click += button1_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 400);
            Controls.Add(BtnReg);
            Controls.Add(TxtPass);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPhone);
            Controls.Add(TxtUser);
            Controls.Add(pictureBox1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TxtUser;
        private TextBox TxtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtEmail;
        private Label label4;
        private Label label5;
        private TextBox TxtPass;
        private Button BtnReg;
    }
}