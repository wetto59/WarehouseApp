namespace WarehouseApp.AddModels
{
    partial class FrmCategoryAdd
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(384, 145);
            // 
            // label1
            // 
            label1.Location = new Point(69, 52);
            label1.Size = new Size(160, 32);
            label1.Text = "Add Category";
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.None;
            TxtName.Location = new Point(69, 223);
            TxtName.Multiline = true;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(245, 38);
            TxtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 197);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // FrmCategoryAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 472);
            Controls.Add(TxtName);
            Controls.Add(label2);
            Name = "FrmCategoryAdd";
            Text = "";
            Load += FrmCategoryAdd_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(TxtName, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private Label label2;
    }
}