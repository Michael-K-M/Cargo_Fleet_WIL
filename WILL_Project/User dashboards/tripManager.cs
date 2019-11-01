using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WILL_Project
{
    public partial class tripManager : Form
    {
        DB_Connection db = new DB_Connection();
        CreateTrip create = new CreateTrip(); // delete later
        String UserID;

        public tripManager(String id)
        {
            this.UserID = id;
            InitializeComponent();
            DisplayName();
        }

        void DisplayName()
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;
            try
            {
                db.closeConnection();

                myReader = db.DisplayStaffName(UserID);

                while (myReader.Read())
                {
                    String FirstName = myReader.GetString(0);
                    String LastName = myReader.GetString(1);

                    label_Names.Text = FirstName + " " + LastName;
                    // tb_LastName.Text = LastName;
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            /*
            Login fm = new Login();
            this.Hide();
            fm.Show();
            */
            Application.Exit();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            SelectTrip st = new SelectTrip(UserID);  //forgot why userID is her tbh
            panel_TM.Controls.Clear();     
            panel_TM.Controls.Add(st);
        }

        private void Btn_FuelPrice_Click(object sender, EventArgs e)
        {
            FuelCon fc = new FuelCon();
            panel_TM.Controls.Clear();
            panel_TM.Controls.Add(fc);
        }

        private void Btn_Incidents_Click(object sender, EventArgs e)
        {
            Trip_Incidents ti = new Trip_Incidents();
            panel_TM.Controls.Clear();
            panel_TM.Controls.Add(ti);
        }

        private void tripManager_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
