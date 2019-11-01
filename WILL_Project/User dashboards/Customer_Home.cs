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
    public partial class Customer_Home : Form
    {
        DB_Connection db = new DB_Connection();
        CreateTrip create = new CreateTrip();
        String UserID;
        public Customer_Home(String id)
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
        private void Btn_CreateTrip_Click(object sender, EventArgs e)
        {
            panel_Home.Controls.Clear();
            panel_Home.Controls.Add(create);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
