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
    public partial class Complete_Trip : UserControl
    {
        String UserID;
        String tripID;
        DB_Connection db = new DB_Connection(); // connecting to bd class
        String V_ID;

        public Complete_Trip(String id )
        {
            this.UserID = id;
            
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo() // display test for completion
        {
            cb_SelectTrip.Items.Clear();
          
            SqlDataReader myReader;
            try
            {
               
                db.closeConnection();
                myReader = db.Fillcombo(UserID);
          
                while (myReader.Read())
                {
                    String sname = myReader.GetString(0); // index number
                    cb_SelectTrip.Items.Add(sname);
              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ChangeStatus() // this will change the status in the db
        {
            
            db.closeConnection();
            db.ChangeTripStatus(tripID);


        }

        void UpdateHisEndDate() 
        {
            db.UpdateTripEndDate(dateTimePicker1.Text, tripID);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // this will display all information related to what the user has selected in the combo box
        private void Cb_SelectTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;

            try
            {

                db.closeConnection();

                myReader = db.DisplayDriverTrip(cb_SelectTrip.Text);

                while (myReader.Read())
                {
                    int Trip_ID = myReader.GetInt32(0);
                    String Name = myReader.GetString(1);
                    String city = myReader.GetString(2);
                    String address = myReader.GetString(3);
                    String postcode = myReader.GetString(4);
                    String Province = myReader.GetString(5);
                    String number = myReader.GetString(6);
                    String Desc = myReader.GetString(7);
                    String Date = myReader.GetString(8);
                    String Vehcle = myReader.GetString(9);
                    String TriID = myReader.GetInt32(10).ToString();
                    String VehicleID = myReader.GetInt32(11).ToString();

                    tb_CName.Text = Name;
                    tb_City.Text = city;
                    tb_Address.Text = address;
                    tb_PC.Text = postcode;
                    tb_Prov.Text = Province;
                    tb_Phone.Text = number;
                    rtb_TripInfo.Text = Desc;

                    V_ID = VehicleID;

                    rtb_TripInfo.Text = Desc;

                    tripID = Trip_ID.ToString();
                }

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

        }

        // this is to update thye drivers trip to complete and refresh the textboxs
        private void Btn_Complete_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            UpdateHisEndDate();
            ChangeStatus();
            db.closeConnection();
            db.ChangeV_AfterTrip(V_ID);
            

            cb_SelectTrip.ResetText();
            tb_CName.ResetText();
            tb_City.ResetText();
            tb_Address.ResetText();
            tb_PC.ResetText();
            tb_Prov.ResetText();
            tb_Phone.ResetText();
            rtb_TripInfo.ResetText();
            dateTimePicker1.ResetText();

            Fillcombo(); 
        }

        private void Complete_Trip_Load(object sender, EventArgs e)
        {

        }
    }
}

