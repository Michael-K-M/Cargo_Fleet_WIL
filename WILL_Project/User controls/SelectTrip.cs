using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;



namespace WILL_Project
{
    
    public partial class SelectTrip : UserControl
    {
        List<string> truckIDComboBox = new List<string>();
        List<string> DriverChoice = new List<string>();
        String UserID;
        DB_Connection db = new DB_Connection();
        String TripID;
        String VehicalID;
        String DriverID;
        public SelectTrip(String id) // This will help track drivers ID for the trip
        {
            this.UserID = id;
           
            InitializeComponent();
            Fillcombo();
            DisplayVType();
            ChooseDriver();
        }
        void Fillcombo() {
          
            cb_SelectTrip.Items.Clear();  // clear drop down before page loads

            SqlDataReader myReader;
            try
            {

                db.closeConnection();
                myReader = db.SelectTrip();
                
                while (myReader.Read())
                {
                    String sname = myReader.GetString(7); // index number
                   
                    cb_SelectTrip.Items.Add(sname);
                }
             //   db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            }

        // desplay vehicle that can be used for trip
        void DisplayVType()
        {
           
            SqlDataReader myReader;
            try
            {
                
                db.closeConnection();
                myReader = db.DisplayVType();
               
                truckIDComboBox.Clear();
                while (myReader.Read())
                {
                    String sname = myReader.GetString(7); // index number
                    
                    cb_SelectV.Items.Add(sname);
                    String test = myReader.GetInt32(0).ToString();
                    truckIDComboBox.Add(test);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // select driver for the trip
        void ChooseDriver()
        {
            SqlDataReader myReader;
            try
            {

                db.closeConnection();
                myReader = db.ChooseDriver();

                DriverChoice.Clear();
                while (myReader.Read())
                {
                    String sname = myReader.GetString(1); // index number

                    cb_Driver.Items.Add(sname);
                    String test = myReader.GetInt32(0).ToString();
                    DriverChoice.Add(test);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // insert the trip info to db
        void fillDB()
        {


            db.closeConnection();

            db.fillDB(DriverID, VehicalID, TripID, dateTimePicker1.Text);
                
           
        }

       // change status for active
        void ChangeStatus()
        {
           
            db.closeConnection();
            db.ChangeStatus(TripID);
            
            Fillcombo(); //reloads
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // dispay trip info 
        private void Cb_SelectTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand();   

            SqlDataReader myReader;
            try
            {
                //  con.Open();
                db.closeConnection();
               
                myReader = db.SelectTripIndex(cb_SelectTrip.Text);

                while (myReader.Read())
                {
                    string rollno = myReader.GetInt32(0).ToString();
                    string name = myReader.GetString(7);
                    string address = myReader.GetString(8);
                    string city = myReader.GetString(9);
                    string postcode = myReader.GetString(10);
                    string province = myReader.GetString(11);
                    string R_Phone = myReader.GetString(12);
                    string R_Description = myReader.GetString(13);

                    tb_CName.Text = name;
                    tb_Address.Text = address;
                    tb_City.Text = city;
                    tb_PC.Text = postcode;
                    tb_Prov.Text = province;
                    tb_Phone.Text = R_Phone;
                    TripID = rollno;
                    rtb_TripInfo.Text = R_Description;

                }

            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            
        }

        private void Label_ST_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_SelectV.SelectedIndex != -1)
            {
                VehicalID = truckIDComboBox[cb_SelectV.SelectedIndex];
            }
            
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            //checks if textbox id null/blank
            if (string.IsNullOrEmpty(cb_SelectTrip.Text) || string.IsNullOrWhiteSpace(cb_SelectTrip.Text)||string.IsNullOrEmpty(cb_Driver.Text) || string.IsNullOrWhiteSpace(cb_Driver.Text)|| string.IsNullOrEmpty(cb_SelectV.Text) || string.IsNullOrWhiteSpace(cb_SelectV.Text)|| string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {

                fillDB();
                ChangeStatus();

                // db.ChangeV_Active();

                cb_SelectTrip.ResetText();
                tb_CName.ResetText();
                tb_City.ResetText();
                tb_Address.ResetText();
                tb_PC.ResetText();
                tb_Prov.ResetText();
                tb_Phone.ResetText();
                rtb_TripInfo.ResetText();
                dateTimePicker1.ResetText();
                cb_SelectV.ResetText();
            }
        }

        private void cb_Driver_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_Driver.SelectedIndex != -1)
            {
                DriverID = DriverChoice[cb_Driver.SelectedIndex];
            }
        }
    }
}
