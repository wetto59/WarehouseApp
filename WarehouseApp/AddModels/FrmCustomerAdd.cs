﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseApp.AddModels
{
    public partial class FrmCustomerAdd : SampleAdd
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

        public FrmCustomerAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void FrmCustomerAdd_Load(object sender, EventArgs e)
        {

        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            TxtName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtName.Width, TxtName.Height, 25, 25));
            TxtPhone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtPhone.Width, TxtPhone.Height, 25, 25));
            TxtEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtEmail.Width, TxtEmail.Height, 25, 25));
        }

        public override void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == ""
                || TxtEmail.Text == ""
                || TxtPhone.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id == 0)
            {
                Customer customer = new Customer()
                {
                    CustomerName = TxtName.Text,
                    CustomerPhone = TxtPhone.Text,
                    CustomerEmail = TxtEmail.Text,
                };

                AddCustomerInDb(customer);
                ClearFields();
            }
        }



        public static void AddCustomerInDb(Customer newCustomer)
        {
            try
            {
                using (var dbContext = new WarehouseDbContext())
                {

                    dbContext.Customers.Add(newCustomer);
                    dbContext.SaveChanges();
                    MessageBox.Show("The Data has saved successfully!");
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

        private void ClearFields()
        {
            TxtName.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtEmail.Text = string.Empty;
        }  
    }
}
