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

namespace WarehouseApp.ViewModels
{
    public partial class FrmPurchaseView : SampleView
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

        public FrmPurchaseView()
        {
            InitializeComponent();

            BtnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnAdd.Width, BtnAdd.Height, 18, 18));
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 18, 18));
        }

        public static List<Product> GetProducts()
        {
            using (var dbContext = new WarehouseDbContext())
            {
                return dbContext.Products.ToList();
            }
        }

        public void LoadDataProducts()
        {
            List<Product> products = GetProducts();
            dataGridView1.DataSource = products;
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            Form dialogFrm = new Form()
            {
                Size = new Size(384, 472),
                StartPosition = FormStartPosition.CenterParent,
            };
            MainClass.BlurBackground(new FrmProductAdd());

        }

        public static void DeleteProductData(Product deletedProduct)
        {
            using (var db = new WarehouseDbContext())
            {
                var product = db.Products.FirstOrDefault(x => x.ID == deletedProduct.ID);
                try
                {
                    if (product != null)
                    {
                        db.Products.Remove(product);
                        db.SaveChanges();
                        MessageBox.Show("The product has been deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Product not found!");

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

        }


        private int productId = 0;

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            productId = (int)selectedRow.Cells["ID"].Value;

            var deletedProduct = new Product
            {
                ID = productId,
            };


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE Book ID: " + productId + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteProductData(deletedProduct);
                LoadDataProducts();

                productId = 0;
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var product = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                UpdateProductInDb(product);
            }
        }

        private void LoadDataIntoDataGridView()
        {
            List<Product> products = GetProducts(); // Fetch products from the database
            dataGridView1.DataSource = new BindingList<Product>(products); // Using BindingList for two-way data binding
        }


        private static void UpdateProductInDb(Product product)
        {
            using (var dbContext = new WarehouseDbContext())
            {
                dbContext.Products.Update(product);
                dbContext.SaveChanges();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form dialogFrm = new Form()
            {
                Size = new Size(384, 472),
                StartPosition = FormStartPosition.CenterParent,
            };
            MainClass.BlurBackground(new FrmPurchaseAdd());
        }
    }
}
