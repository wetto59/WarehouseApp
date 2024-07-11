using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp.Methods
{
    public class MainClass
    {
        public static void LoadData(DataGridView grv, ListBox lb) 
        {

        } 

        public static void BlurBackground(Form Model) 
        {
            Form Backround = new Form();
            
                Backround.StartPosition = FormStartPosition.Manual;
                Backround.FormBorderStyle = FormBorderStyle.None;
                Backround.Opacity = 0.5d;
                Backround.BackColor = Color.Black;
                Backround.WindowState = FormWindowState.Maximized;
                Backround.Location = frmMain.Instance.Location;
                Backround.ShowInTaskbar = false;
                Backround.Show();
                Model.Owner = Backround;
                Model.ShowDialog(Backround);
                Backround.Dispose();

           
        }
    }
}
