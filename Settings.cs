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
    public partial class Settings : Main_Template
    {
        string dbUsername = null;
        string dbEmail = null;
        string dbName = null;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Users.db");
            string query = "SELECT * FROM Users WHERE UID = @uid";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            cmd.Parameters.Add("@uid", DbType.Int16).Value = Login.Global.UID;

            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string dbUsername = reader.GetString(1);
            string dbEmail = reader.GetString(3);
            string dbName = reader.GetString(4);
            reader.Close();
            con.Close();

            txtUsernamePH.Text = dbUsername;
            txtNamePH.Text = dbName;
            txtEmailPH.Text = dbEmail;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();
        }
        public Point getCurrentPoint()  //Grabs the current position of the window and returns it.
        {
            int windowX = this.Left;
            int windowY = this.Top;
            Point currentPoint = new Point(windowX, windowY);
            return currentPoint;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Alert_ChangePassword menu = new Alert_ChangePassword();
            menu.Show();
        }

        private void txtUsernamePH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNamePH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmailPH_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
