namespace WarehouseApp.AddModels
{
    partial class FrmSupplierAdd
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
            TxtPhone = new TextBox();
            label4 = new Label();
            TxtEmail = new TextBox();
            label3 = new Label();
            TxtName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(629, 145);
            // 
            // label1
            // 
            label1.Location = new Point(69, 52);
            label1.Size = new Size(181, 32);
            label1.Text = "Supplier Details";
            // 
            // TxtPhone
            // 
            TxtPhone.BorderStyle = BorderStyle.None;
            TxtPhone.Location = new Point(331, 201);
            TxtPhone.Multiline = true;
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(245, 38);
            TxtPhone.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 175);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 20;
            label4.Text = "Phone";
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.Location = new Point(52, 288);
            TxtEmail.Multiline = true;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(245, 38);
            TxtEmail.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 262);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 18;
            label3.Text = "Email";
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.None;
            TxtName.Location = new Point(52, 201);
            TxtName.Multiline = true;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(245, 38);
            TxtName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 175);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // FrmSupplierAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 504);
            Controls.Add(TxtPhone);
            Controls.Add(label4);
            Controls.Add(TxtEmail);
            Controls.Add(label3);
            Controls.Add(TxtName);
            Controls.Add(label2);
            Name = "FrmSupplierAdd";
            Text = "FrmSupplierAdd";
            Load += FrmSupplierAdd_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(TxtName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(TxtEmail, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(TxtPhone, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox TxtPhone;
        private Label label4;
        public TextBox TxtEmail;
        private Label label3;
        public TextBox TxtName;
        private Label label2;
    }
}