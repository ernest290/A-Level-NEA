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
    public partial class Database_Editor : Main_Template
    {
        public Database_Editor()
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

        private void Database_Editor_Load(object sender, EventArgs e)
        {

        }

        private void inpUserQuery_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnExecute2_Click(object sender, EventArgs e)
        {
            if (txtComponents.ForeColor == Color.Lime)
            {
                try
                {
                    SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Components.db");
                    string query = inpComponentsQuery.Text;
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Alert_Success menu = new Alert_Success();
                    menu.Show();
                }
                catch (Exception)
                {
                    Alert_Error menu = new Alert_Error();
                    menu.Show();
                }
            }
            else
            {
                Alert_ConnectionClosed menu = new Alert_ConnectionClosed();
                menu.Show();
            }
        }
        private void btnExecute1_Click(object sender, EventArgs e)
        {
            if (txtUser.ForeColor == Color.Lime)
            {
                try
                {
                    SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Users.db");
                    string query = inpUserQuery.Text;
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    List<string> Rows = new List<string>();
                    SQLiteDataReader reader = cmd.ExecuteReader();          
                    while (reader.Read())
                    {
                        Rows.Add($"UID = {reader.GetInt16(0)}, Username = {reader.GetString(1)}, Password = {reader.GetString(2)}, Email = {reader.GetString(3)}, Name = {reader.GetString(4)} ");
                    }

                    reader.Close();
                    con.Close();
                    if (Rows.Any())
                    {
                        MessageBox.Show(string.Join("\n\n", Rows));
                    }
                    else
                    {
                        Alert_Success menu = new Alert_Success();
                        menu.Show();
                    }
                    Rows.Clear();
                }
                catch (Exception)
                {
                    Alert_Error menu = new Alert_Error();
                    menu.Show();
                }
            }
            else
            {
                Alert_ConnectionClosed menu = new Alert_ConnectionClosed();
                menu.Show();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenCon1_Click(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Lime;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenCon2_Click(object sender, EventArgs e)
        {
            txtComponents.ForeColor = Color.Lime;
        }

        private void txtComponents_TextChanged(object sender, EventArgs e)
        {

        }

        public void UsersConnection()
        {

        }

        private void btnCloseCon1_Click(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Red;
        }

        private void btnCloseCon2_Click(object sender, EventArgs e)
        {
            txtComponents.ForeColor = Color.Red;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(Login.Global.UID == 1)
            {
                Staff_Main_Menu menu = new Staff_Main_Menu();
                menu.Show();
                menu.DesktopLocation = getCurrentPoint();
                this.Hide();
            }
            else
            {
                Main_Menu menu = new Main_Menu();
                menu.Show();
                menu.DesktopLocation = getCurrentPoint();
                this.Hide();
            }
        }
    }
}
