namespace WarehouseApp.AddModels
{
    partial class FrmPurchaseAdd
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TxtCost = new TextBox();
            label6 = new Label();
            TxtQuantity = new TextBox();
            label5 = new Label();
            TxtBarcode = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label7 = new Label();
            CmbSupplier = new ComboBox();
            CmbProduct = new ComboBox();
            TxtAmmount = new TextBox();
            label8 = new Label();
            BtnBrowse = new Button();
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(1115, 126);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.Size = new Size(188, 32);
            label1.Text = "Purchase Details";
            // 
            // TxtCost
            // 
            TxtCost.BorderStyle = BorderStyle.None;
            TxtCost.Location = new Point(704, 286);
            TxtCost.Multiline = true;
            TxtCost.Name = "TxtCost";
            TxtCost.Size = new Size(107, 36);
            TxtCost.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(719, 260);
            label6.Name = "label6";
            label6.Size = new Size(44, 23);
            label6.TabIndex = 25;
            label6.Text = "Cost";
            // 
            // TxtQuantity
            // 
            TxtQuantity.BorderStyle = BorderStyle.None;
            TxtQuantity.Location = new Point(591, 286);
            TxtQuantity.Multiline = true;
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(107, 36);
            TxtQuantity.TabIndex = 4;
            TxtQuantity.TextChanged += TxtQuantity_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(600, 260);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 23;
            label5.Text = "Quantity";
            // 
            // TxtBarcode
            // 
            TxtBarcode.BorderStyle = BorderStyle.None;
            TxtBarcode.Location = new Point(83, 286);
            TxtBarcode.Multiline = true;
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new Size(250, 36);
            TxtBarcode.TabIndex = 2;
            TxtBarcode.KeyDown += TxtBarcode_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 260);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 21;
            label4.Text = "Barcode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 177);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 17;
            label2.Text = "Supplier";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(83, 205);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 177);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 28;
            label3.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 260);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 29;
            label7.Text = "Product";
            // 
            // CmbSupplier
            // 
            CmbSupplier.AllowDrop = true;
            CmbSupplier.FlatStyle = FlatStyle.Flat;
            CmbSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbSupplier.FormattingEnabled = true;
            CmbSupplier.Location = new Point(353, 203);
            CmbSupplier.Name = "CmbSupplier";
            CmbSupplier.Size = new Size(226, 36);
            CmbSupplier.TabIndex = 1;
            // 
            // CmbProduct
            // 
            CmbProduct.AllowDrop = true;
            CmbProduct.FlatStyle = FlatStyle.Flat;
            CmbProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbProduct.FormattingEnabled = true;
            CmbProduct.Location = new Point(353, 286);
            CmbProduct.Name = "CmbProduct";
            CmbProduct.Size = new Size(226, 36);
            CmbProduct.TabIndex = 3;
            CmbProduct.SelectedIndexChanged += CmbProduct_SelectedIndexChanged;
            // 
            // TxtAmmount
            // 
            TxtAmmount.BorderStyle = BorderStyle.None;
            TxtAmmount.Location = new Point(817, 286);
            TxtAmmount.Multiline = true;
            TxtAmmount.Name = "TxtAmmount";
            TxtAmmount.Size = new Size(107, 36);
            TxtAmmount.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(832, 260);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 32;
            label8.Text = "Ammount";
            // 
            // BtnBrowse
            // 
            BtnBrowse.BackColor = Color.FromArgb(95, 61, 204);
            BtnBrowse.FlatStyle = FlatStyle.Flat;
            BtnBrowse.ForeColor = Color.Transparent;
            BtnBrowse.Location = new Point(939, 286);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(100, 36);
            BtnBrowse.TabIndex = 7;
            BtnBrowse.Text = "Add";
            BtnBrowse.UseVisualStyleBackColor = false;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(91, 64, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = Color.FromArgb(239, 243, 248);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(95, 61, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column1, Column2, Column3, Column4 });
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(31, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(90, 64, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(91, 64, 204);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(1060, 285);
            dataGridView1.TabIndex = 35;
            // 
            // Column5
            // 
            Column5.HeaderText = "Sr";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Id";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantity";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cost";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ammount";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // FrmPurchaseAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 749);
            Controls.Add(dataGridView1);
            Controls.Add(BtnBrowse);
            Controls.Add(TxtAmmount);
            Controls.Add(label8);
            Controls.Add(CmbProduct);
            Controls.Add(CmbSupplier);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(TxtCost);
            Controls.Add(label6);
            Controls.Add(TxtQuantity);
            Controls.Add(label5);
            Controls.Add(TxtBarcode);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "FrmPurchaseAdd";
            Text = "FrmPurchaseAdd";
            Load += FrmPurchaseAdd_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(TxtBarcode, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(TxtQuantity, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(TxtCost, 0);
            Controls.SetChildIndex(dateTimePicker1, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(CmbSupplier, 0);
            Controls.SetChildIndex(CmbProduct, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(TxtAmmount, 0);
            Controls.SetChildIndex(BtnBrowse, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCost;
        private Label label6;
        private TextBox TxtQuantity;
        private Label label5;
        private TextBox TxtBarcode;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label7;
        private ComboBox CmbSupplier;
        private ComboBox CmbProduct;
        private TextBox TxtAmmount;
        private Label label8;
        private Button BtnBrowse;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}