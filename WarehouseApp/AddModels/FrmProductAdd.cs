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
using WarehouseApp.Data;
using WarehouseApp.Models;
using WarehouseApp.View;
using WarehouseApp.ViewModels;

namespace WarehouseApp.AddModels
{
    public partial class FrmProductAdd : SampleAdd
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

        public FrmProductAdd()
        {
            InitializeComponent();
            LoadCategoriesIntoComboBox();
        }

        private void FrmProductAdd_Load(object sender, EventArgs e)
        {
            TxtName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtName.Width, TxtName.Height, 25, 25));
            TxtBarcode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtBarcode.Width, TxtBarcode.Height, 25, 25));
            TxtCost.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtCost.Width, TxtCost.Height, 25, 25));
            TxtPrice.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtPrice.Width, TxtPrice.Height, 25, 25));
        }

        public int id = 0;
        public int catId = 0;

        public override void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == ""
                || TxtBarcode.Text == ""
                || TxtCost.Text == ""
                || TxtPrice.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id == 0)
            {
                Product product = new Product()
                { 
                    Name = TxtName.Text,
                    Barcode = TxtBarcode.Text,
                    Price = Convert.ToDouble(TxtPrice.Text),
                    Cost =  Convert.ToDouble(TxtCost.Text),
                    CatID = Convert.ToInt32(comboBox1.SelectedValue),
                };

                AddProductInDb(product);
                ClearFields();
           }
        }



        public static void AddProductInDb(Product newProduct)
        {
            try
            {
                using (var dbContext = new WarehouseDbContext())
                {

                    dbContext.Products.Add(newProduct);
                    dbContext.SaveChanges();
                    MessageBox.Show("The Data has been saved successfully!");
                }
            }
            catch (Exception ex)
            {
                var detailedMessage = $"An error occurred: {ex.Message}";
                if (ex.InnerException != null)
                {
                    detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategoriesIntoComboBox()
        {
            List<Category> categories = FrmCategoryView.GetCaregories();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";  
            comboBox1.ValueMember = "ID";      
        }


        private void ClearFields()
        {
            TxtName.Text = string.Empty;
            TxtBarcode.Text = string.Empty;
            TxtCost.Text = string.Empty;
            TxtPrice.Text = string.Empty;
        }
    
    }
}
