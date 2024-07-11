using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApp.AddModels;
using WarehouseApp.Data;
using WarehouseApp.Methods;
using WarehouseApp.Models;

namespace WarehouseApp.ViewModels
{
    public partial class FrmSupplierView : SampleView
    {
        public FrmSupplierView()
        {
            InitializeComponent();
        }

        private void FrmSupplierView_Load(object sender, EventArgs e)
        {
            LoadDataSupplierss();
        }

        private static frmMain _instance;
        public static frmMain Instance => _instance ?? (_instance = new frmMain());

        private static List<Supplier> GetSuppliers()
        {
            using (var dbContext = new WarehouseDbContext())
            {
                return dbContext.Suppliers.ToList();
            }
        }

        private void LoadDataSupplierss()
        {
            List<Supplier> suppliers = GetSuppliers();
            dataGridView1.DataSource = suppliers;
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form dialogFrm = new Form()
            {
                Size = new Size(800, 450),
                StartPosition = FormStartPosition.CenterParent,
            };
            MainClass.BlurBackground(new FrmSupplierAdd());
        }

        public int supplierId = 0;




        public static void DeleteSupplierrData(Supplier deletedSupplier)
        {
            using (var db = new WarehouseDbContext())
            {
                var supplier = db.Suppliers.FirstOrDefault(x => x.SupplierId == deletedSupplier.SupplierId);
                try
                {
                    if (supplier != null)
                    {
                        db.Suppliers.Remove(supplier);
                        db.SaveChanges();
                        MessageBox.Show("The customer has been deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Customer not found!");

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            supplierId = (int)selectedRow.Cells["supplierId"].Value;

            var deletedSupplier = new Supplier
            {
                SupplierId = supplierId,
            };


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE Book ID: " + supplierId + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteSupplierrData(deletedSupplier);
                LoadDataSupplierss();

                supplierId = 0;
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            Form dialogFrm = new Form()
            {
                Size = new Size(800, 450),
                StartPosition = FormStartPosition.CenterParent,
            };
            MainClass.BlurBackground(new FrmSupplierAdd());
        }
    }
}
