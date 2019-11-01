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
    public partial class AddService : UserControl
    {
        DB_Connection db = new DB_Connection(); // connecting to bd class
        int Vehicle_ID;

        // creating input whitelist
        int i = 0;
        Regex regex = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ]");
        string badchar;
        Regex regex2 = new Regex(@"[^0-9 ]");

        public AddService()
        {
            InitializeComponent();
            Fillcombo(); //activate method
           
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
        public string inputMask2(string txb) // input method mask that filters
        {
            string inMethod;
            inMethod = txb;
            string isbad = "";

            MatchCollection matches = regex2.Matches(inMethod);

            if (matches.Count > 0)
            {
                ++i;

                Console.WriteLine(i + " invalid caracter " + i);
                isbad = "1";
            }

            return isbad;

        }


        void Fillcombo()
        {

            cb_VehicleMake.Items.Clear();  // clear drop down before page loads

            SqlDataReader myReader;
           

                db.closeConnection();
                myReader = db.DisplayStandard(); // calls method to show vehicle make

                while (myReader.Read())
                {
                    String sname = myReader.GetString(0); // index number

                    cb_VehicleMake.Items.Add(sname);

                }

        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        //checks if textbox id null/blank
        {
            if (string.IsNullOrEmpty(tb_TM.Text) || string.IsNullOrWhiteSpace(tb_TM.Text)) 
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {

                db.closeConnection(); // close db connection for new method

                SqlCommand cmd = db.createService(); // this function will add to the DB

                cmd.Parameters.Add("@Vehicle_Make", cb_VehicleMake.Text);
                cmd.Parameters.Add("@Vehicle_Model", tb_Model.Text);
                cmd.Parameters.Add("@Number_Plate", cb_NP.Text);
                cmd.Parameters.Add("@Total_Milage", tb_TM.Text);
                cmd.Parameters.Add("@Date", DTP.Value.Date);
                cmd.Parameters.Add("@Vehicle_ID", Vehicle_ID);

                cmd.ExecuteNonQuery(); // initiate the save to db

                // clear textboxs
                tb_Model.ResetText();
                tb_TM.ResetText();
                DTP.ResetText();
                db.closeConnection();
                db.ChangeV_Incident(Vehicle_ID.ToString());

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_NP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // this will display vehicle number plates

            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;
            try
            {
                db.closeConnection();

                myReader = db.StandardServiceInfo(cb_VehicleMake.Text, cb_NP.Text);

                while (myReader.Read())
                {
                 
                    string Model = myReader.GetString(0);


                    tb_Model.Text = Model;

                    GetID();

                }

            }
            catch (Exception exx)
            {
              //  MessageBox.Show(exx.Message);
            }



        }

        private void cb_VehicleMake_SelectedIndexChanged(object sender, EventArgs e)
        {
           cb_NP.Items.Clear();  // clear drop down before page loads

            //display vehicle make in dropdown
            SqlDataReader myReader;
            try
            {

                db.closeConnection();
                myReader = db.DisplayStandardNP(cb_VehicleMake.Text);

                while (myReader.Read())
                {
                    String sname = myReader.GetString(0); // index number

                    cb_NP.Items.Add(sname);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //this method will grab the Vehicle id
        void GetID()
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

                    Vehicle_ID = Name;
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        ////////////////////// This activated the whitelisting to the combo boxs

        private void tb_Model_TextChanged(object sender, EventArgs e)
        {
            tb_Model.MaxLength = 255;
            badchar = inputMask(tb_Model.Text);
            if (badchar == "1")
            {
                tb_Model.ResetText();
                MessageBox.Show("Sorry but you have entered Vehicle Model incorrectly . We do not comply to symbols.");
            }
        }

        private void tb_TM_TextChanged(object sender, EventArgs e)
        {
            tb_TM.MaxLength = 255;
            badchar = inputMask2(tb_TM.Text);
            if (badchar == "1")
            {
                tb_TM.ResetText();
                MessageBox.Show("Sorry but you have entered Total Milage incorrectly . We do not comply to symbols.");
            }
        }
    }
}
