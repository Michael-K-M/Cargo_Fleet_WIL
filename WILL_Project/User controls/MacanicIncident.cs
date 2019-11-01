using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WILL_Project
{
    public partial class MacanicIncident : UserControl
    {
        DB_Connection db = new DB_Connection(); // connecting to db class
        String ServiceID;
        int Vehicle_ID;

        // creating input whitelist
        int i = 0;
        Regex regex = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ,.]");
        string badchar;

        public MacanicIncident()
        {
            InitializeComponent();
            Fillcombo();
        }

        // display vehicle name that needs to be serviced for incedent
        void Fillcombo()
        {

            cb_DisplayService.Items.Clear();

            SqlDataReader myReader;
            try
            {

                db.closeConnection();

                myReader = db.IncedintService();

                while (myReader.Read())
                {
                    String sname = myReader.GetString(3); // index number

                    cb_DisplayService.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        ////////////////////// This activated the whitelisting to the combo boxs
        public string inputMask(string txb)
        {
            string inMethod;
            inMethod = txb;
            string isbad = "";

            MatchCollection matches = regex.Matches(inMethod);

            if (matches.Count > 0)
            {
                ++i;

                Console.WriteLine(i + " invalid caracter " + i);
                isbad = "1";
            }

            return isbad;

        }

        private void cb_DisplayService_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;
            try
            {
                //  con.Open();
                db.closeConnection();

                myReader = db.SelectedIncService(cb_DisplayService.Text);

                while (myReader.Read())
                {
                    //ServiceID, Vehicle_Make, Vehicle_Model, Number_Plate, Date, Vehicle_ID

                    string ServiceID1 = myReader.GetInt32(0).ToString();
                    string Vehicle_Make = myReader.GetString(1);
                    string Vehicle_Model = myReader.GetString(2);
                    string Number_Plate = myReader.GetString(3);
                    string Date = myReader.GetString(4);
                    string Problem = myReader.GetString(5);
                    int VehicleID = myReader.GetInt32(6);

                    ServiceID = ServiceID1;
                    Vehicle_ID = VehicleID;


                    tb_VMake.Text = Vehicle_Make;
                    tb_VM.Text = Vehicle_Model;
                    tb_NP.Text = Number_Plate;
                    // tb_TMilage.Text = Total_Milage;
                    tb_Date.Text = Date;
                    rtb_Problem.Text = Problem;


                }

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }


       

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (cb_DisplayService.ToString() == "" || rtb_Requirement.Text == "" || tb_TP.Text == "")
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {


                db.closeConnection();

                SqlCommand cmd = db.CompleteService();

                // ServiceID, Description, Price

                cmd.Parameters.Add("@ServiceID", ServiceID);
                cmd.Parameters.Add("@Description", rtb_Requirement.Text);
                cmd.Parameters.Add("@Price", tb_TP.Text);
                cmd.ExecuteNonQuery();

                rtb_Requirement.ResetText();
                tb_TP.ResetText();

                tb_VMake.ResetText();
                tb_VM.ResetText();
                tb_NP.ResetText();
                tb_Date.ResetText();
                rtb_Problem.ResetText();

                ChangeStatus(); // was commented before to get the status of vehicle to change



                db.closeConnection();
                db.ChangeV_Fixed(Vehicle_ID.ToString());
            }

        }

        void ChangeStatus()
        {
            db.closeConnection();
           db.ChangeService(ServiceID);


          
        }

        private void rtb_Requirement_TextChanged(object sender, EventArgs e)
        {
            rtb_Requirement.MaxLength = 255;
            badchar = inputMask(rtb_Requirement.Text);
            if (badchar == "1")
            {
                rtb_Requirement.ResetText();
                MessageBox.Show("Sorry but you have entered the Vehicle Requirements incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_TP_TextChanged(object sender, EventArgs e)
        {
            tb_TP.MaxLength = 255;
            badchar = inputMask(tb_TP.Text);
            if (badchar == "1")
            {
                tb_TP.ResetText();
                MessageBox.Show("Sorry but you have entered Total Price incorrectly . We do not comply to symbols ");
            }
        }
    }
}
