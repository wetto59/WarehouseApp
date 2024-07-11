namespace WarehouseApp.AddModels
{
    partial class FrmProductAdd
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
            TxtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            TxtBarcode = new TextBox();
            label4 = new Label();
            TxtCost = new TextBox();
            label5 = new Label();
            TxtPrice = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(589, 126);
            // 
            // label1
            // 
            label1.Size = new Size(175, 32);
            label1.Text = "Product Details";
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.None;
            TxtName.Location = new Point(46, 170);
            TxtName.Multiline = true;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(245, 36);
            TxtName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 144);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 144);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 8;
            label3.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(307, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 36);
            comboBox1.TabIndex = 10;
            // 
            // TxtBarcode
            // 
            TxtBarcode.BorderStyle = BorderStyle.None;
            TxtBarcode.Location = new Point(46, 245);
            TxtBarcode.Multiline = true;
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new Size(245, 36);
            TxtBarcode.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 219);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 11;
            label4.Text = "Barcode";
            // 
            // TxtCost
            // 
            TxtCost.BorderStyle = BorderStyle.None;
            TxtCost.Location = new Point(307, 245);
            TxtCost.Multiline = true;
            TxtCost.Name = "TxtCost";
            TxtCost.Size = new Size(107, 36);
            TxtCost.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 219);
            label5.Name = "label5";
            label5.Size = new Size(44, 23);
            label5.TabIndex = 13;
            label5.Text = "Cost";
            // 
            // TxtPrice
            // 
            TxtPrice.BorderStyle = BorderStyle.None;
            TxtPrice.Location = new Point(426, 245);
            TxtPrice.Multiline = true;
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(107, 36);
            TxtPrice.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 219);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 15;
            label6.Text = "Price";
            // 
            // FrmProductAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 427);
            Controls.Add(TxtPrice);
            Controls.Add(label6);
            Controls.Add(TxtCost);
            Controls.Add(label5);
            Controls.Add(TxtBarcode);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(TxtName);
            Controls.Add(label2);
            Name = "FrmProductAdd";
            Text = "FrmProductAdd";
            Load += FrmProductAdd_Load;
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(TxtName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(TxtBarcode, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(TxtCost, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(TxtPrice, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox TxtBarcode;
        private Label label4;
        private TextBox TxtCost;
        private Label label5;
        private TextBox TxtPrice;
        private Label label6;
    }
}