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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using WarehouseApp.Data;
using WarehouseApp.Models;
using WarehouseApp.View;

namespace WarehouseApp.AddModels
{
    public partial class FrmPurchaseAdd : SampleAdd
    {
        public FrmPurchaseAdd()
        {
            InitializeComponent();

            CmbProduct.SelectedIndexChanged += CmbProduct_SelectedIndexChanged;

        }



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



        public int id = 0;

        public override void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void BtnSave_Click(object sender, EventArgs e)
        {


        }


        private void GetDetails()
        {
            using (var db = new WarehouseDbContext())
            {
                if (CmbProduct.SelectedValue != null)
                {
                    if (int.TryParse(CmbProduct.SelectedValue.ToString(), out int selectedProductId))
                    {
                        var product = db.Products.FirstOrDefault(p => p.ID == selectedProductId);

                        if (product != null)
                        {
                            TxtCost.Text = product.Cost.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected product ID is not a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private static List<Product> GetProducts()
        {
            using (var dbContext = new WarehouseDbContext())
            {
                return dbContext.Products.ToList();
            }
        }

        private static List<Supplier> GetSuppliers()
        {
            using (var dbContext = new WarehouseDbContext())
            {
                return dbContext.Suppliers.ToList();
            }
        }

        private void LoadProductsIntoComboBox()
        {
            using (var db = new WarehouseDbContext())
            {
                List<Product> products = GetProducts();
                CmbProduct.DataSource = products;
                CmbProduct.DisplayMember = "Name";
                CmbProduct.ValueMember = "ID";
            }
        }

        private void LoadSuppliersIntoComboBox()
        {
            using (var db = new WarehouseDbContext())
            {
                List<Supplier> suppliers = GetSuppliers();
                CmbSupplier.DataSource = suppliers;
                CmbSupplier.DisplayMember = "SupplierName";
                CmbSupplier.ValueMember = "SupplierID";
            }
        }

        private void ClearFields()
        {
            TxtAmmount.Text = string.Empty;
            TxtBarcode.Text = string.Empty;
            TxtCost.Text = string.Empty;
            TxtQuantity.Text = string.Empty;
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDetails();
        }

        private void Calculate()
        {
            double qty = 0;
            double cost = 0;
            double amt = 0;

            double.TryParse(TxtQuantity.Text, out qty);
            double.TryParse(TxtCost.Text, out cost);

            amt = qty * cost;
            TxtAmmount.Text = amt.ToString();
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void TxtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            using (var db = new WarehouseDbContext())
            {
                string selectedProductBarcode = CmbProduct.Text;

                var product = db.Products.FirstOrDefault(p => p.Barcode == selectedProductBarcode);

                if (product != null)
                {
                    TxtCost.Text = product.Barcode;

                }
                else
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Calculate();
                TxtBarcode.Text = "";
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            string pID;
            string pName;
            string qty;
            string cost;
            string amt;

            pName = CmbProduct.Text;
            pID = CmbProduct.SelectedValue.ToString();
            qty = TxtQuantity.Text;
            cost = TxtCost.Text;
            amt = TxtAmmount.Text;

           
            dataGridView1.Rows.Add(0, pID, pName, qty, cost, amt);
        }

        private void FrmPurchaseAdd_Load(object sender, EventArgs e)
        {
            TxtAmmount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtAmmount.Width, TxtAmmount.Height, 25, 25));
            TxtBarcode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtBarcode.Width, TxtBarcode.Height, 25, 25));
            TxtCost.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtCost.Width, TxtCost.Height, 25, 25));
            TxtQuantity.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtQuantity.Width, TxtQuantity.Height, 25, 25));
            CmbProduct.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, CmbProduct.Width, CmbProduct.Height, 25, 25));
            CmbSupplier.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, CmbSupplier.Width, CmbSupplier.Height, 25, 25));


            LoadProductsIntoComboBox();
            LoadSuppliersIntoComboBox();
        }

       
    }
}
