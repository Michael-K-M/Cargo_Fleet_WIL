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
    public partial class Driver : Form
    {
        DB_Connection db = new DB_Connection();
        String UserID;
       
        public Driver(String id)
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
            /*Login fm = new Login();
            this.Hide();
            fm.Show();*/
            Application.Exit();
        }

        private void Driver_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // SelectTrip st = new SelectTrip(UserID);
            //panel_D.Controls.Clear();
            //panel_D.Controls.Add(st);

            ViewDriverTrip dt = new ViewDriverTrip(UserID);
            panel_D.Controls.Clear();
            panel_D.Controls.Add(dt);
        }

        private void Btn_EndTrip_Click(object sender, EventArgs e)
        {
            Complete_Trip st = new Complete_Trip(UserID);
            panel_D.Controls.Clear();
            panel_D.Controls.Add(st);
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
