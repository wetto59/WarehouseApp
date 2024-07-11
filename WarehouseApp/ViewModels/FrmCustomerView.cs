using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApp.AddModels;
using WarehouseApp.Data;
using WarehouseApp.Methods;
using WarehouseApp.Models;

namespace WarehouseApp.ViewModels
{
    public partial class FrmCustomerView : SampleView
    {
        public FrmCustomerView()
        {
            InitializeComponent();
        }

        private static frmMain _instance;
        public static frmMain Instance => _instance ?? (_instance = new frmMain());
        readonly int id = 0;

        private void FrmCustomerView_Load(object sender, EventArgs e)
        {
            LoadDataCustomers();
        }


        private static List<Customer> GetCustomers()
        {
            using (var dbContext = new WarehouseDbContext())
            {
                return dbContext.Customers.ToList();
            }
        }

        private void LoadDataCustomers()
        {
            List<Customer> customers = GetCustomers();
            dataGridView1.DataSource = customers;
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form dialogFrm = new Form()
            {
                Size = new Size(800, 450),
                StartPosition = FormStartPosition.CenterParent,
            };
            MainClass.BlurBackground(new FrmCustomerAdd());
        }

        public int customerId = 0;

        private FrmCustomerAdd frmCustomerAdd;

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            customerId = (int)selectedRow.Cells["customerId"].Value;

            var deletedCustomer = new Customer
            {
                CustomerId = customerId,
            };


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE Book ID: " + customerId + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteCustomerData(deletedCustomer);
                LoadDataCustomers(); 
                
                customerId = 0;
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void DeleteCustomerData(Customer deletedCustomer)
        {
            using (var db = new WarehouseDbContext())
            {
                var customer = db.Customers.FirstOrDefault(x => x.CustomerId == deletedCustomer.CustomerId);
                try
                {
                    if (customer != null)
                    {
                        db.Customers.Remove(customer);
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
    }
}
