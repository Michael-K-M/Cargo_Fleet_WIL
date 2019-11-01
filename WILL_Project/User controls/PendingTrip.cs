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

namespace WILL_Project
{
    public partial class PendingTrip : UserControl
    {
        DB_Connection db = new DB_Connection(); // connecting to bd class

        String UserID;
       
        String TripID;
        

        public PendingTrip()
        {
            InitializeComponent();
            Fillcombo();
        }

        // this will decline the trip
        private void btn_Create_Click(object sender, EventArgs e)
        {
            //checks if textbox id null/blank
            if (string.IsNullOrEmpty(cb_Trip.Text) || string.IsNullOrWhiteSpace(cb_Trip.Text))
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {
                db.closeConnection();
                db.DeclineTripRequest(TripID);

                cb_Trip.ResetText();
                tb_SenderName.ResetText();
                tb_SenderSA.ResetText();
                tb_SenderCity.ResetText();
                tb_senderPC.ResetText();
                tb_SendersProv.ResetText();
                tb_SenderPhone.ResetText();

                tb_RName.ResetText();
                R_SAddress.ResetText();
                tb_RTown.ResetText();
                tb_RPostcode.ResetText();
                tb_RProv.ResetText();
                tb_RPhone.ResetText();
                tb_RDesc.ResetText();
                MessageBox.Show("Please inform customer that their trip has not been accepted");
            }
        
        }

        // display trip info depended on combo box
        private void cb_Trip_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;
            try
            {
                db.closeConnection();

                myReader = db.RequestTrip();

                while (myReader.Read())
                {
                    string rollNum = myReader.GetInt32(0).ToString();
                    string S_Name = myReader.GetString(1);
                    string S_StreetAddress = myReader.GetString(2);
                    string S_City = myReader.GetString(3);
                    string S_Postcode = myReader.GetString(4);
                    string S_Province = myReader.GetString(5);
                    string S_Phone = myReader.GetString(6);
                    
                    string R_Name = myReader.GetString(7);
                    string R_StreetAddress = myReader.GetString(8);
                    string R_City = myReader.GetString(9);
                    string R_Postcode = myReader.GetString(10);
                    string R_Province = myReader.GetString(11);
                    string R_Phone = myReader.GetString(12);
                    string R_Description = myReader.GetString(13);
                    string Status = myReader.GetString(14);


                    tb_SenderName.Text = S_Name;
                    tb_SenderSA.Text = S_StreetAddress;
                    tb_SenderCity.Text = S_City;
                    tb_senderPC.Text = S_Postcode;
                    tb_SendersProv.Text = S_Province;
                    tb_SenderPhone.Text = S_Phone;

                    tb_RName.Text = R_Name;
                    R_SAddress.Text = R_StreetAddress;
                    tb_RTown.Text = R_City;
                    tb_RPostcode.Text = R_Postcode;
                    tb_RProv.Text = R_Province;
                    tb_RPhone.Text = R_Phone;
                    tb_RDesc.Text = R_Description;


                    TripID = rollNum;

                   // rtb_TripInfo.Text = R_Description;




                }

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        // desplay trip request
        void Fillcombo()
        {

            cb_Trip.Items.Clear();  // clear drop down before page loads

            SqlDataReader myReader;
            try
            {

                db.closeConnection();
                myReader = db.RequestTrip();

                while (myReader.Read())
                {
                    String sname = myReader.GetString(7); // index number

                    cb_Trip.Items.Add(sname);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


            void ChangeStatus()
        {
            

            db.closeConnection();
            db.ChangeStatus(TripID);

            Fillcombo(); //reloads
        }

        // approve trip request
        private void btn_Approve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_Trip.Text) || string.IsNullOrWhiteSpace(cb_Trip.Text))
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {


                db.closeConnection();
                db.ChangeRequest(TripID);

                cb_Trip.ResetText();
                tb_SenderName.ResetText();
                tb_SenderSA.ResetText();
                tb_SenderCity.ResetText();
                tb_senderPC.ResetText();
                tb_SendersProv.ResetText();
                tb_SenderPhone.ResetText();

                tb_RName.ResetText();
                R_SAddress.ResetText();
                tb_RTown.ResetText();
                tb_RPostcode.ResetText();
                tb_RProv.ResetText();
                tb_RPhone.ResetText();
                tb_RDesc.ResetText();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
