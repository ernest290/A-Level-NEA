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
    public partial class Alert_ChangePassword : Form
    {
        public Alert_ChangePassword()
        {
            InitializeComponent();
        }

        private void Alert_ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Users.db"))
            {
                con.Open();
                string query = "UPDATE Users SET Password = @password WHERE Username = @username;";
                string getPassQuery = "SELECT * FROM Users WHERE Username = @username";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                SQLiteCommand cmd2 = new SQLiteCommand(getPassQuery, con);

                cmd2.Parameters.Add("@username", DbType.String).Value = Login.Global.userName.ToLower();
                cmd.Parameters.Add("@username", DbType.String).Value = Login.Global.userName.ToLower();          //Adds SQL parameters to use C# variables in query.
                cmd.Parameters.Add("@password", DbType.String).Value = inpNewPass.Text;

                SQLiteDataReader reader = cmd2.ExecuteReader();
                reader.Read();
                string dbPassword = reader.GetString(2);
                reader.Close();


                if (inpNewPass.Text.All(char.IsLower) || !inpNewPass.Text.Any(Char.IsDigit) || inpNewPass.Text.Length < 7)
                {
                    Alert_PassReqNotMet menu = new Alert_PassReqNotMet();
                    menu.Show();

                }
                else if (inpNewPass.Text != inpConfirmNewPass.Text)
                {
                    Alert_PassNotMatching menu = new Alert_PassNotMatching();
                    menu.Show();
                }
                else if (inpOldPass.Text != dbPassword)
                {
                    Alert_OldPassNotMatch menu = new Alert_OldPassNotMatch();
                    menu.Show();
                }
                else
                {
                    dbPassword = null;
                    cmd.ExecuteNonQuery();
                    this.Hide();
                }
                con.Close();
            }
        }

        private void inpOldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpConfirmNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
