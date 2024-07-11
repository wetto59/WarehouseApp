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

namespace WarehouseApp
{
    public partial class FrmRegister : Sample
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

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "" || TxtEmail.Text == "" || TxtPhone.Text == "" || TxtPass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (WarehouseDbContext db = new WarehouseDbContext())
            {
                var existingUser = db.Admins.FirstOrDefault(a => a.Username == TxtUser.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var newAdmin = new Admin
                    {
                        Username = TxtUser.Text,
                        Email = TxtEmail.Text,
                        Phone_Number = TxtPhone.Text,
                        Password = TxtPass.Text,
                        Date_Registered = DateTime.Now,
                    };
                    AddAdminInDb(newAdmin);
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    this.Hide();
                }
            }
        }

        private static void AddAdminInDb(Admin newAdmin)
        {
            using (var db = new WarehouseDbContext())
            {
                db.Admins.Add(newAdmin);
                db.SaveChanges();
                MessageBox.Show("Registration successful!");
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            TxtUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtUser.Width, TxtUser.Height, 30, 30));
            TxtEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtEmail.Width, TxtEmail.Height, 30, 30));
            TxtPhone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtPhone.Width, TxtPhone.Height, 30, 30));
            TxtPass.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtPass.Width, TxtPass.Height, 30, 30));
            BtnReg.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnReg.Width, BtnReg.Height, 30, 30));
        }
    }
}
