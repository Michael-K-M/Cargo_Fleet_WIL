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
    public partial class Trip_Incidents : UserControl
    {
        DB_Connection db = new DB_Connection(); // connecting to db class
        int V_ID;
        int TripID;

        // creating input whitelist
        int i = 0;
        Regex regex = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ,.]");
        string badchar;

        public Trip_Incidents()
        {
            InitializeComponent();
            Fillcombo();
        }

        // input method mask that filters
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

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            //checks if textbox id null/blank
            if (string.IsNullOrEmpty(cb_NP.Text) || string.IsNullOrWhiteSpace(cb_NP.Text)||string.IsNullOrEmpty(tb_Location.Text) || string.IsNullOrWhiteSpace(tb_Location.Text)||string.IsNullOrEmpty(rtb_Cause.Text) || string.IsNullOrWhiteSpace(rtb_Cause.Text)||string.IsNullOrEmpty(rtb_Parties.Text) || string.IsNullOrWhiteSpace(rtb_Parties.Text))
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {


                db.closeConnection();

                SqlCommand cmd = db.IncidentRec();
                //Location, CauseOf, Driver, VehicleMake, NumberPlate, OtherParties VehicleModel
                cmd.Parameters.Add("@Location", tb_Location.Text);
                cmd.Parameters.Add("@CauseOf", rtb_Cause.Text);
                cmd.Parameters.Add("@Driver", tb_Driver.Text);
                cmd.Parameters.Add("@VehicleMake", tb_Make.Text);
                cmd.Parameters.Add("@VehicleModel", tb_Model.Text);
                cmd.Parameters.Add("@NumberPlate", cb_NP.Text);
                cmd.Parameters.Add("@OtherParties", rtb_Parties.Text);
                cmd.Parameters.Add("@Vehicle_ID", V_ID);


                cmd.ExecuteNonQuery();

                tb_Location.ResetText();
                rtb_Cause.ResetText();
                tb_Driver.ResetText();
                tb_Make.ResetText();
                cb_NP.ResetText();
                rtb_Parties.ResetText();


                db.closeConnection();
                db.ChangeV_Incident(V_ID.ToString());

                db.closeConnection();
                db.ChangeIncTrip(V_ID.ToString(TripID.ToString()));
            }
        }

        void Fillcombo()
        {

            cb_NP.Items.Clear();  // clear drop down before page loads

            SqlDataReader myReader;
            try
            {

                db.closeConnection();
                myReader = db.Select_NP();

                while (myReader.Read())
                {
                    String sname = myReader.GetString(0); // index number
                    int VehicleID = myReader.GetInt32(1);  ///delete this shit
                    int T_ID = myReader.GetInt32(2);
                    cb_NP.Items.Add(sname);

                    TripID = T_ID;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // display info to screen
        void fillInfo()
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;
            try
            {
                db.closeConnection();

                myReader = db.TripInc(cb_NP.Text);

                while (myReader.Read())
                {

                    string DriverName = myReader.GetString(0);
                    string V_Make = myReader.GetString(1);
                    string V_Model = myReader.GetString(2);

                    tb_Driver.Text = DriverName;
                    tb_Make.Text = V_Make;
                    tb_Model.Text = V_Model;

                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
    
        // this will grab the vehicle id 
        private void cb_NP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;
            try
            {
                //  con.Open();
                db.closeConnection();

                myReader = db.VID(cb_NP.Text);

                while (myReader.Read())
                {

                    int Name = myReader.GetInt32(0);

                   // cb_NP.Text = Name;

                    V_ID = Name;
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

            fillInfo();
        }

        ////////////////////// This activated the whitelisting to the combo boxs
        private void tb_Location_TextChanged(object sender, EventArgs e)
        {
            tb_Location.MaxLength = 255;
            badchar = inputMask(tb_Location.Text);
            if (badchar == "1")
            {
                tb_Location.ResetText();
                MessageBox.Show("Sorry but you have entered Location incorrectly . We do not comply to symbols ");

            }
        }

        private void rtb_Cause_TextChanged(object sender, EventArgs e)
        {
            rtb_Cause.MaxLength = 255;
            badchar = inputMask(rtb_Cause.Text);
            if (badchar == "1")
            {
                rtb_Cause.ResetText();
                MessageBox.Show("Sorry but you have entered Cause of Incident incorrectly . We do not comply to symbols ");

            }
        }

        private void rtb_Parties_TextChanged(object sender, EventArgs e)
        {
            rtb_Parties.MaxLength = 255;
            badchar = inputMask(rtb_Parties.Text);
            if (badchar == "1")
            {
                rtb_Parties.ResetText();
                MessageBox.Show("Sorry but you have entered Other Parties Involved incorrectly . We do not comply to symbols ");

            }
        }
    }
}
