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

namespace WarehouseApp
{
    public partial class SampleAdd : Sample
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

        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void SampleAdd_Load(object sender, EventArgs e)
        {
            BtnSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnSave.Width, BtnSave.Height, 18, 18));
            BtnClose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnClose.Width, BtnClose.Height, 18, 18));

        }

        public virtual void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void BtnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
