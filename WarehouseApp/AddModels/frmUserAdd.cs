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
    public partial class frmUserAdd : SampleAdd
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

        public frmUserAdd()
        {
            InitializeComponent();
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            TxtName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtName.Width, TxtName.Height, 25, 25));
            TxtUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtUser.Width, TxtUser.Height, 25, 25));
            TxtPhone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtPhone.Width, TxtPhone.Height, 25, 25));
            TxtPass.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtPass.Width, TxtPass.Height, 25, 25));
            BtnBrowse.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnBrowse.Width, BtnBrowse.Height, 25, 25));
        }

        public int id = 0;

        public override void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == ""
                || TxtPass.Text == ""
                || TxtPhone.Text == ""
                || TxtPic == null
                || TxtUser.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id == 0)
            {
                Participant participant = new Participant() 
                {
                    Name = TxtName.Text,
                    Username = TxtUser.Text,
                    Password = TxtPass.Text,
                    Phone = TxtPhone.Text,
                };

                AddParticipantInDb(participant);
                ClearFields();
            }
        }




       

        public static void AddParticipantInDb(Participant newParticipant)
        {
            try
            {
                using (var dbContext = new WarehouseDbContext())
                {

                    dbContext.Participants.Add(newParticipant);
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

        public string filePath = "";
        readonly Byte[] imageByteArray;

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (.jpg, .png)|*.png, *jpg ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                TxtPic.Image = new Bitmap(filePath);
            }
        }

        private void ClearFields() 
        {
            TxtName.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtPass.Text = string.Empty;
            TxtUser.Text = string.Empty;
        }
    }
}
