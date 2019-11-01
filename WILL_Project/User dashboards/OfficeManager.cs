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
    public partial class OfficeManager : Form
    {
        DB_Connection db = new DB_Connection();
        Create_User create = new Create_User();
        OM_ViewTrips vt = new OM_ViewTrips();
        String UserID;
        public OfficeManager(String id)
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cb_Select_Update.Text = "";
            panel_Home.Controls.Clear();
            panel_Home.Controls.Add(create);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            cb_Select_Update.Text = "";
            panel_Home.Controls.Clear();
            panel_Home.Controls.Add(vt);
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

        private void Btn_infoAdmin_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_TM_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_SM_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_TSM_Click(object sender, EventArgs e)
        {
            
        }

        private void OfficeManager_Load(object sender, EventArgs e)
        {

        }

        private void btn_PendingTrip_Click(object sender, EventArgs e)
        {
            cb_Select_Update.Text = "";
            PendingTrip pt = new PendingTrip();
            panel_Home.Controls.Clear();
            panel_Home.Controls.Add(pt);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // logout
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_Select_Update_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (cb_Select_Update.SelectedItem.ToString().Equals("Employees"))
            {
                Update_Employees ue = new Update_Employees();
                panel_Home.Controls.Clear();
                panel_Home.Controls.Add(ue);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Vehicals"))
            {
                Update_Vehical uv = new Update_Vehical();
                panel_Home.Controls.Clear();
                panel_Home.Controls.Add(uv);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Service"))
            {
                Update_Service us = new Update_Service();
                panel_Home.Controls.Clear();
                panel_Home.Controls.Add(us);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Fuel Consumption"))
            {
                Update_FuelCon ufc = new Update_FuelCon();
                panel_Home.Controls.Clear();
                panel_Home.Controls.Add(ufc);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Employee Rate"))
            {
                Update_Emp_Rates uer = new Update_Emp_Rates();
                panel_Home.Controls.Clear();
                panel_Home.Controls.Add(uer);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Trip"))
            {
                Update_Trip safgh = new Update_Trip();
                panel_Home.Controls.Clear();
                panel_Home.Controls.Add(safgh);
            }

    
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_vehicle_report_Click(object sender, EventArgs e)
        {
            Report_vehicle rv = new Report_vehicle();
            panel_Home.Controls.Clear();
            panel_Home.Controls.Add(rv);
        }

        private void btn_emp_report_Click(object sender, EventArgs e)
        {
            Report_employees re = new Report_employees();
            panel_Home.Controls.Clear();
            panel_Home.Controls.Add(re);
        }
    }
}
