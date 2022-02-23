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
    public partial class PcBuilder_AdvIntel : Main_Template
    {
        public PcBuilder_AdvIntel()
        {
            InitializeComponent();
            GetComponents();
        }
        void GetComponents()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Components.db");
            con.Open(); //Open SQLite connection.

            string queryCPU = "SELECT * FROM CPU_Intel";
            string queryMobo = "SELECT * FROM Motherboard_LGA1151";
            string queryGPU = "SELECT * FROM GPU";
            string queryRAM = "SELECT * FROM RAM_DDR4";
            SQLiteCommand cmd = new SQLiteCommand(queryCPU, con);
            SQLiteCommand cmd2 = new SQLiteCommand(queryMobo, con);
            SQLiteCommand cmd3 = new SQLiteCommand(queryGPU, con);
            SQLiteCommand cmd4 = new SQLiteCommand(queryRAM, con);

            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboCPU.Items.Add(reader.GetString(1));
            }

            reader.Close();

            SQLiteDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                comboMotherboard.Items.Add(reader2.GetString(1));
            }

            reader2.Close();

            SQLiteDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                comboGPU.Items.Add(reader3.GetString(1));
            }

            reader3.Close();

            SQLiteDataReader reader4 = cmd4.ExecuteReader();

            while (reader4.Read())
            {
                comboRAM.Items.Add(reader4.GetString(1));
            }

            reader3.Close();
            con.Close();
        }

        private void PcBuilder_AdvIntel_Load(object sender, EventArgs e)
        {

        }

        private void comboCPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void comboMotherboard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboGPU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboRAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            /* Opens database connection. */

            SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Components.db");
            con.Open(); //Open SQLite connection.

            float CPUtxt = 0;
            float Mobotxt = 0;
            float GPUtxt = 0;
            float RAMtxt = 0;

            if (comboCPU.Text.Any())
            {
                /* Refreshes all the combobox fields to grab current value. */

                dataCPU.Refresh();

                /* Creates queries, commands and parameters for all components. */

                string queryCPU2 = "SELECT * FROM CPU_Intel WHERE Name = @NameCPU;";
                SQLiteCommand cmd = new SQLiteCommand(queryCPU2, con);
                cmd.Parameters.Add("@NameCPU", DbType.String).Value = comboCPU.Text;

                /* Executes readers for all components. */

                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();
                CPUtxt = reader.GetFloat(6);

                /* Outputs all components data. */

                dataCPU.Text = $"Name: {comboCPU.Text}, APU:{reader.GetString(2)}, Cores: {reader.GetString(3)}, Clock Speed: {reader.GetString(4)} GHz, Boost Clock: {reader.GetString(5)} GHz, Price: ~${reader.GetFloat(6)}";

                reader.Close();
            }
            if (comboMotherboard.Text.Any())
            {
                dataMotherboard.Refresh();

                string queryMobo2 = "SELECT * FROM Motherboard_LGA1151 WHERE Name = @NameMobo;";
                SQLiteCommand cmd2 = new SQLiteCommand(queryMobo2, con);
                cmd2.Parameters.Add("@NameMobo", DbType.String).Value = comboMotherboard.Text;

                SQLiteDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();
                Mobotxt = reader2.GetFloat(10);

                dataMotherboard.Text = $"Name: {comboMotherboard.Text}, Brand:{reader2.GetString(2)}, Chipset: {reader2.GetString(3)}, RAM Slots: {reader2.GetInt16(4)}, Max RAM: {reader2.GetInt16(5)}, Max Clock Speed: {reader2.GetInt16(6)} MHz, M.2 Slots: {reader2.GetInt16(7)}, Wifi:{reader2.GetString(8)}, M.2 Support:{reader2.GetString(9)} Price: ~${reader2.GetFloat(10)}";

                reader2.Close();
            }
            if (comboGPU.Text.Any())
            {
                dataGPU.Refresh();

                string queryGPU2 = "SELECT * FROM GPU WHERE Name = @NameGPU;";
                SQLiteCommand cmd3 = new SQLiteCommand(queryGPU2, con);
                cmd3.Parameters.Add("@NameGPU", DbType.String).Value = comboGPU.Text;

                SQLiteDataReader reader3 = cmd3.ExecuteReader();
                reader3.Read();
                GPUtxt = reader3.GetFloat(7);

                dataGPU.Text = $"Name: {comboGPU.Text}, Chipset:{reader3.GetString(2)}, VRAM: {reader3.GetString(3)}, Memory: {reader3.GetInt16(4)} GB, Core Clock: {reader3.GetInt16(5)}, Boost Clock: {reader3.GetInt16(6)} GHz, Price: ~${reader3.GetFloat(7)}";

                reader3.Close();
            }
            if (comboRAM.Text.Any())
            {
                dataRAM.Refresh();

                string queryRAM2 = "SELECT * FROM RAM_DDR4 WHERE Name = @NameRAM;";
                SQLiteCommand cmd4 = new SQLiteCommand(queryRAM2, con);
                cmd4.Parameters.Add("@NameRAM", DbType.String).Value = comboRAM.Text;

                SQLiteDataReader reader4 = cmd4.ExecuteReader();
                reader4.Read();
                RAMtxt = reader4.GetFloat(6);

                dataRAM.Text = $"Name: {comboRAM.Text}, Speed:{reader4.GetInt16(2)} MHz, RAM Sticks: {reader4.GetInt16(3)}, Modules: {reader4.GetInt16(4)} GB, Total RAM: {reader4.GetInt16(5)} GB, Price: ~${reader4.GetFloat(6)}";

                reader4.Close();
            }

            dataCPU.Refresh();
            dataPrice.Text = $"Price ~ ${CPUtxt + Mobotxt + GPUtxt + RAMtxt}";

            con.Close();

        }

        private void dataCPU_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataMotherboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGPU_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataRAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            PcBuilder_Main menu = new PcBuilder_Main();
            menu.Show();
            menu.DesktopLocation = getCurrentPoint();
            this.Close();
        }
        public Point getCurrentPoint()  //Grabs the current position of the window and returns it.
        {
            int windowX = this.Left;
            int windowY = this.Top;
            Point currentPoint = new Point(windowX, windowY);
            return currentPoint;
        }

        private void dataPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompatibility_Click(object sender, EventArgs e)
        {
            /* Opens database connection. */

            SQLiteConnection con = new SQLiteConnection("Data Source=D:/Users/Ernest/Documents/A-Level NEA/Databases/Components.db");
            con.Open(); //Open SQLite connection.

            /* Creates queries, commands and parameters for all components. */

            string queryCPU2 = "SELECT * FROM CPU_Intel WHERE Name = @NameCPU;";
            SQLiteCommand cmd = new SQLiteCommand(queryCPU2, con);
            cmd.Parameters.Add("@NameCPU", DbType.String).Value = comboCPU.Text;

            string queryMobo2 = "SELECT * FROM Motherboard_LGA1151 WHERE Name = @NameMobo;";
            SQLiteCommand cmd2 = new SQLiteCommand(queryMobo2, con);
            cmd2.Parameters.Add("@NameMobo", DbType.String).Value = comboMotherboard.Text;

            string queryGPU2 = "SELECT * FROM GPU WHERE Name = @NameGPU;";
            SQLiteCommand cmd3 = new SQLiteCommand(queryGPU2, con);
            cmd3.Parameters.Add("@NameGPU", DbType.String).Value = comboGPU.Text;

            string queryRAM2 = "SELECT * FROM RAM_DDR4 WHERE Name = @NameRAM;";
            SQLiteCommand cmd4 = new SQLiteCommand(queryRAM2, con);
            cmd4.Parameters.Add("@NameRAM", DbType.String).Value = comboRAM.Text;

            /* Executes readers for all components. */

            SQLiteDataReader CPU_Reader = cmd.ExecuteReader();
            CPU_Reader.Read();

            SQLiteDataReader Mobo_Reader = cmd2.ExecuteReader();
            Mobo_Reader.Read();

            SQLiteDataReader GPU_Reader = cmd3.ExecuteReader();
            GPU_Reader.Read();

            SQLiteDataReader RAM_Reader = cmd4.ExecuteReader();
            RAM_Reader.Read();

            if(Mobo_Reader.GetInt16(5) < RAM_Reader.GetInt16(5))
            {
                txtCompatibility.ForeColor = Color.Red;
                txtCompatibility.Text = "Motherboard doesnt support that much RAM.";
            }
            else if (Mobo_Reader.GetInt16(6) < RAM_Reader.GetInt16(2))
            {
                txtCompatibility.ForeColor = Color.Red;
                txtCompatibility.Text = "Motherboard doesnt support that high clock speed.";
            }
            else if (Mobo_Reader.GetInt16(4) < RAM_Reader.GetInt16(3))
            {
                txtCompatibility.ForeColor = Color.Red;
                txtCompatibility.Text ="Motherboard doesnt have enough RAM slots.";
            }
            else
            {
                txtCompatibility.ForeColor = Color.Lime;
                txtCompatibility.Text = "Compatible.";
            }

            CPU_Reader.Close();
            Mobo_Reader.Close();
            GPU_Reader.Close();
            RAM_Reader.Close();
            con.Close();

        }
    }
}
