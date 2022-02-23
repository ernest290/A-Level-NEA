using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace A_Level_NEA
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();          
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Users.db");
            string query = "SELECT * FROM Users WHERE UID = @uid";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.Add("@uid", DbType.String).Value = Login.Global.UID;
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string name = reader.GetString(4);
            con.Close();

            txtWelcome.Text = $"Welcome back, {name}!";
        }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            this.Text = "Hello";
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //Quits the program.
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PcBuilder_Main menu = new PcBuilder_Main();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }
        public Point getCurrentPoint()  //Grabs the current position of the window and returns it.
        {
            int windowX = this.Left;
            int windowY = this.Top;
            Point currentPoint = new Point(windowX, windowY);
            return currentPoint;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login menu = new Login();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();
        }

        private void btnMinimisee_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   //Minimises the window.
        }

        private void btnDBEditor_Click(object sender, EventArgs e)
        {
            if(Login.Global.UID != 1)
            {
                Alert_NotStaff menu = new Alert_NotStaff();
                menu.Show();
            }
            else
            {
                Database_Editor menu = new Database_Editor();
                menu.Show();
                menu.DesktopLocation = getCurrentPoint();
                this.Hide();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings menu = new Settings();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
