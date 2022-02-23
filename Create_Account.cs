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
    public partial class Create_Account : Form
    {
        public Create_Account()
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
        public void LoginPage()
        {

            Login menu = new Login();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();

            //Hides login window and displays the main menu.
        }
        private void btnHere_Click(object sender, EventArgs e)
        {
            LoginPage();
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Users.db");
            string query = "INSERT INTO Users (Username, Password, Email, Name) VALUES (@username, @password, @email, @name)";
            SQLiteCommand cmd = new SQLiteCommand(query, con);


            /* Parameters */

            cmd.Parameters.Add("@username", DbType.String).Value = inpUsername.Text.ToLower();
            cmd.Parameters.Add("@password", DbType.String).Value = inpPassword.Text;
            cmd.Parameters.Add("@email", DbType.AnsiStringFixedLength).Value = inpEmail.Text;
            cmd.Parameters.Add("@name", DbType.String).Value = inpName.Text;

            try
            {
                if (inpUsername.Text.ToLower() == "" || inpPassword.Text == "" || inpConfirmPassword.Text == "" || inpEmail.Text == "" || inpName.Text == "")
                {
                    Alert_EmptyFields menu = new Alert_EmptyFields();
                    menu.Show();
                }
                else if (inpPassword.Text != inpConfirmPassword.Text)
                {
                    Alert_PassNotMatching menu = new Alert_PassNotMatching();
                    menu.Show();
                }
                else if (!inpEmail.Text.Contains("@"))
                {
                    Alert_InvalidEmail menu = new Alert_InvalidEmail();
                    menu.Show();
                }
                else if(inpPassword.Text.All(char.IsLower) || !inpPassword.Text.Any(Char.IsDigit) || inpPassword.Text.Length < 7)
                {
                    Alert_PassReqNotMet menu = new Alert_PassReqNotMet();
                    menu.Show();
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    LoginPage();
                    this.Hide();

                    Alert_AccountSuccess menu = new Alert_AccountSuccess();
                    menu.Show();
                }

            }
            catch(Exception)
            {
                Alert_Error menu = new Alert_Error();
                menu.Show();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginPage();
        }

        private void inpUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   //Minimises the window.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //Quits the program.
        }


    }
}
