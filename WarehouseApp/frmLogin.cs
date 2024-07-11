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

namespace WarehouseApp
{
    public partial class frmLogin : Sample
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

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            BtnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnLogin.Width, BtnLogin.Height, 30, 30));
            TxtUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtUser.Width, TxtUser.Height, 30, 30));
            TxtPass.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtPass.Width, TxtPass.Height, 30, 30));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using (WarehouseDbContext db = new WarehouseDbContext())
            {
                if (TxtUser.Text == "" || TxtPass.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                var existingAdmin = db.Admins.FirstOrDefault(a => a.Username == TxtUser.Text);
                if (existingAdmin == null)
                {
                    MessageBox.Show("The username doesn't exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (existingAdmin.Password != TxtPass.Text)
                {
                    MessageBox.Show("The username or password is incorrect", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Login Successfully!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
        }

        private void Lbl_RegisterFrm_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }
    }
}
