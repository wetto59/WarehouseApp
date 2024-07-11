namespace WarehouseApp
{
    partial class frmUserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAdd));
            label2 = new Label();
            TxtName = new TextBox();
            TxtPass = new TextBox();
            label3 = new Label();
            TxtUser = new TextBox();
            label4 = new Label();
            TxtPhone = new TextBox();
            label5 = new Label();
            TxtPic = new PictureBox();
            BtnBrowse = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtPic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Size = new Size(140, 32);
            label1.Text = "User Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 143);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.None;
            TxtName.Location = new Point(23, 169);
            TxtName.Multiline = true;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(245, 38);
            TxtName.TabIndex = 3;
            // 
            // TxtPass
            // 
            TxtPass.BorderStyle = BorderStyle.None;
            TxtPass.Location = new Point(23, 256);
            TxtPass.Multiline = true;
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(245, 38);
            TxtPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 230);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // TxtUser
            // 
            TxtUser.BorderStyle = BorderStyle.None;
            TxtUser.Location = new Point(302, 169);
            TxtUser.Multiline = true;
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(245, 38);
            TxtUser.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 143);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // TxtPhone
            // 
            TxtPhone.BorderStyle = BorderStyle.None;
            TxtPhone.Location = new Point(302, 256);
            TxtPhone.Multiline = true;
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(245, 38);
            TxtPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 230);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 8;
            label5.Text = "Phone";
            // 
            // TxtPic
            // 
            TxtPic.Image = (Image)resources.GetObject("TxtPic.Image");
            TxtPic.Location = new Point(603, 159);
            TxtPic.Name = "TxtPic";
            TxtPic.Size = new Size(146, 120);
            TxtPic.SizeMode = PictureBoxSizeMode.Zoom;
            TxtPic.TabIndex = 10;
            TxtPic.TabStop = false;
            // 
            // BtnBrowse
            // 
            BtnBrowse.BackColor = Color.FromArgb(123, 92, 214);
            BtnBrowse.FlatStyle = FlatStyle.Flat;
            BtnBrowse.ForeColor = Color.Transparent;
            BtnBrowse.Location = new Point(627, 285);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(100, 32);
            BtnBrowse.TabIndex = 11;
            BtnBrowse.Text = "Browse";
            BtnBrowse.UseVisualStyleBackColor = false;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // frmUserAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBrowse);
            Controls.Add(TxtPic);
            Controls.Add(TxtPhone);
            Controls.Add(label5);
            Controls.Add(TxtUser);
            Controls.Add(label4);
            Controls.Add(TxtPass);
            Controls.Add(label3);
            Controls.Add(TxtName);
            Controls.Add(label2);
            Name = "frmUserAdd";
            Text = "frmUserAdd";
            Load += frmUserAdd_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(TxtName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(TxtPass, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(TxtUser, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(TxtPhone, 0);
            Controls.SetChildIndex(TxtPic, 0);
            Controls.SetChildIndex(BtnBrowse, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox TxtName;
        private TextBox TxtPass;
        private Label label3;
        private TextBox TxtUser;
        private Label label4;
        private TextBox TxtPhone;
        private Label label5;
        private PictureBox TxtPic;
        private Button BtnBrowse;
    }
}