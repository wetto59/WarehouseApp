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
using WarehouseApp.AddModels;
using WarehouseApp.Data;
using WarehouseApp.Methods;
using WarehouseApp.Models;
using static System.Windows.Forms.DataFormats;

namespace WarehouseApp.View
{
    public partial class FrmCategoryView : SampleView
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

        private static frmMain _instance;
        public static frmMain Instance => _instance ?? (_instance = new frmMain());

        public FrmCategoryView()
        {
            InitializeComponent();

            BtnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnAdd.Width, BtnAdd.Height, 18, 18));
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 18, 18));
            LoadDataCategories();

        }

        private void FrmCategoryView_Load(object sender, EventArgs e)
        {

        }

        private void FrmUserView_Load(object sender, EventArgs e)
        {
            LoadDataCategories();
        }

        public static List<Category> GetCaregories()
        {
            using (var dbContext = new WarehouseDbContext())
            {
                return dbContext.Categories.ToList();
            }
        }

        private void LoadDataCategories()
        {
            List<Category> categories = GetCaregories();
            dataGridView1.DataSource = categories;
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form dialogFrm = new Form()
            {
                Size = new Size(384, 472),
                StartPosition = FormStartPosition.CenterParent,
            };
            MainClass.BlurBackground(new FrmCategoryAdd());


        }
    }
}
