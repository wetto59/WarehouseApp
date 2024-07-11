namespace WarehouseApp
{
    partial class SampleAdd
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            BtnClose = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 61, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 126);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(61, 45);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 0;
            label1.Text = "Sample Header";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(BtnClose);
            panel2.Controls.Add(BtnSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 116);
            panel2.TabIndex = 1;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.Crimson;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.Transparent;
            BtnClose.Location = new Point(193, 35);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(113, 43);
            BtnClose.TabIndex = 1;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click_1;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(95, 61, 204);
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.Transparent;
            BtnSave.Location = new Point(46, 35);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(113, 43);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // SampleAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SampleAdd";
            Text = "SampleAdd";
            Load += SampleAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button2;
        private Button BtnSave;
        public Panel panel1;
        public Label label1;
        private Button BtnClose;
    }
}