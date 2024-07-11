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
using WarehouseApp.Methods;
using WarehouseApp.Models;

namespace WarehouseApp
{
    public partial class FrmUserView : SampleView
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


        private static frmMain _instance;
        public static frmMain Instance => _instance ?? (_instance = new frmMain());

        public FrmUserView()
        {
            InitializeComponent();
            BtnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnAdd.Width, BtnAdd.Height, 18, 18));
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 18, 18));
            LoadDataParticipants();
        }

        private void FrmUserView_Load(object sender, EventArgs e)
        {
            LoadDataParticipants();
        }

        private static List<Participant> GetParticipants()
        {
            using (var dbContext = new WarehouseDbContext())
            {
                return dbContext.Participants.ToList();
            }
        }

        private void LoadDataParticipants()
        {
            List<Participant> participants = GetParticipants();
            dataGridView1.DataSource = participants;
        }


        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            Form dialogFrm = new Form()
            {
                Size = new Size(800, 450),
                StartPosition = FormStartPosition.CenterParent,
            };
            MainClass.BlurBackground(new frmUserAdd());
        }
    }
}
