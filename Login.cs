using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace A_Level_NEA
{

    public partial class Login : Form
    {

        private void LoginPage()
        {

            Login menu = new Login();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();

            //Hides login window and displays the main menu.
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void inpPassword_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;   //Make it so that the user can press the accept button by pressing enter.
        }

        public Login()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //Quits the program.
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   //Minimises the window.
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string dbUsername = null;
            string dbPassword = null;
            Global.UID = 0; //Variable is global so that other parts can access to to check if the member is staff.

            SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Users.db");
            con.Open(); //Open SQLite connection.

            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";   //SQL query.
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.Add("@username", DbType.String).Value = inpUsername.Text.ToLower();          //Adds SQL parameters to use C# variables in query.
            cmd.Parameters.Add("@password", DbType.String).Value = inpPassword.Text;

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Global.UID = reader.GetInt16(0);    //Reads from DB and grabs UID and stores it in a variable.


                if (reader.GetString(1) == inpUsername.Text.ToLower() && reader.GetString(2) == inpPassword.Text)   //Grabs username and password and checks it against info in database. 
                {
                    //if (Global.UID == 1)     //If the UID is 1 this means it is a staff account.
                    //{
                    //    Staff_Main_Menu menu3 = new Staff_Main_Menu();      //Therefore it will open the staff menu form.
                    //    menu3.Show();
                    //    menu3.DesktopLocation = getCurrentPoint();
                    //}
                    //else
                    //{
                    //    Main_Menu menu = new Main_Menu();
                    //    menu.Show();
                    //    menu.DesktopLocation = getCurrentPoint();       //Else it will open the normal user form.
                    //}

                    Main_Menu menu = new Main_Menu();
                    menu.Show();
                    menu.DesktopLocation = getCurrentPoint();

                    /* Closes all connections, closes login form and displays a successful login alert */

                    reader.Close();
                    con.Close();

                    this.Hide();
                    Alert_LoginSuccesful menu2 = new Alert_LoginSuccesful();
                    menu2.Show();
                }

                dbUsername = null;
                dbPassword = null;
            }
            catch (Exception)    // If the details are incorrect an alert will appear and clears text boxes.
            {
                Alert_CredsIncorrect menu = new Alert_CredsIncorrect();
                menu.Show();
                inpUsername.Text = "";
                inpPassword.Text = "";
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Create_Account menu = new Create_Account();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Hide();

            Alert_PassReq menu2 = new Alert_PassReq();
            menu2.Show();
        }

        private void inpUsername_TextChanged(object sender, EventArgs e)
        {
            Global.userName = inpUsername.Text;
        }
        public static class Global
        {
            public static int UID;
            public static string userName;

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_MouseDown(object sender, MouseEventArgs e)
        {
            inpPassword.PasswordChar = '\0';
            btnShowPasswordSmall.BringToFront();
        }

        private void guna2ImageButton1_MouseUp(object sender, MouseEventArgs e)
        {
            inpPassword.PasswordChar = '*';
            btnShowPasswordSmall.SendToBack();
        }

        private void btnShowPasswordSmall_Click(object sender, EventArgs e)
        {

        }
    }
}
