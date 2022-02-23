using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Level_NEA
{
    public partial class PcBuilder_Main : Main_Template
    {
        public PcBuilder_Main()
        {
            InitializeComponent();
        }
        public Point getCurrentPoint()  //Grabs the current position of the window and returns it.
        {
            int windowX = this.Left;
            int windowY = this.Top;
            Point currentPoint = new Point(windowX, windowY);
            return currentPoint;
        }

        private void PcBuilder_Main_Load(object sender, EventArgs e)
        {

        }

        private void lblLotOut_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();
        }

        private void btnIntelPC_Click(object sender, EventArgs e)
        {
            PcBuilder_AdvIntel menu = new PcBuilder_AdvIntel();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();
        }
    }
}
