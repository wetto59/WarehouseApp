using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApp.Models;
using WarehouseApp.View;
using WarehouseApp.ViewModels;

namespace WarehouseApp
{
    public partial class frmMain : Sample
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );


        public frmMain()
        {
            InitializeComponent();
        }

        static frmMain _obj;

        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BtnMaximize.PerformClick();
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 60, 60));
            CirclePictureBox(pictureBox1);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void CirclePictureBox(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            Region rg = new Region(obj);
            pictureBox.Region = rg;
        }

        public void AddControls(Form F)
        {
            this.MainPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            MainPanel.Controls.Add(F);
            F.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            AddControls(new FrmUserView());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCateg_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCategoryView());
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCustomerView());
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            AddControls(new FrmSupplierView());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            AddControls(new FrmProductView());
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            AddControls(new FrmPurchaseView());
        }
    }
}
