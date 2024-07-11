using Microsoft.VisualBasic.ApplicationServices;
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

namespace WarehouseApp.AddModels
{
    public partial class FrmCategoryAdd : SampleAdd
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

        public FrmCategoryAdd()
        {
            InitializeComponent();
        }

        private void FrmCategoryAdd_Load(object sender, EventArgs e)
        {

        }
        
        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            TxtName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtName.Width, TxtName.Height, 25, 25));
        }

        public int id = 0;

        public override void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
                Category category = new Category()
                {
                    Name = TxtName.Text,
                };

                AddCategoryInDb(category);
                ClearFields();
            
        }

        public static void AddCategoryInDb(Category newCategory)
        {
            try
            {
                using (var dbContext = new WarehouseDbContext())
                {
                    
                    dbContext.Categories.Add(newCategory);
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

        

        private void ClearFields()
        {
            TxtName.Text = string.Empty;
        }
    }
}

