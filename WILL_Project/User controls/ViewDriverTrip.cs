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
    public partial class ViewDriverTrip : UserControl
    {
        String UserID;
        DB_Connection db = new DB_Connection(); // connecting to db class
        String TID;
        String V_ID;

        public ViewDriverTrip(String id)
        {
            this.UserID = id;
            InitializeComponent();
            Fillcombo();
          
        }

        // desplay drivers trip details when selected on the combobox
        private void Cb_ViewTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;
            try
            {
                db.closeConnection();

                myReader = db.DisplayDriverTrip(cb_ViewTrip.Text);

                while (myReader.Read())
                {

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
                    tb_DOT.Text = Date;
                    tb_Vehicle.Text = Vehcle;

                    TID = TriID;
                    V_ID = VehicleID;
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        // fill trip into combo box
        void Fillcombo()
        {

            cb_ViewTrip.Items.Clear();  // clear drop down before page loads

            SqlDataReader myReader;
            try
            {
                
                db.closeConnection();
                myReader = db.SelectAssinedTrip(UserID);

                while (myReader.Read())
                {
                    String sname = myReader.GetString(0); // index number

                    cb_ViewTrip.Items.Add(sname);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            //checks if textbox id null/blank
            if (string.IsNullOrEmpty(cb_ViewTrip.Text) || string.IsNullOrWhiteSpace(cb_ViewTrip.Text))
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {


                db.closeConnection();
                db.ChangeTStatus(TID);

                db.closeConnection();
                db.ChangeV_Status(V_ID);

                cb_ViewTrip.ResetText();
                tb_CName.ResetText();
                tb_City.ResetText();
                tb_Address.ResetText();
                tb_PC.ResetText();
                tb_Prov.ResetText();
                tb_Phone.ResetText();
                rtb_TripInfo.ResetText();
                tb_DOT.ResetText();
                tb_Vehicle.ResetText();
            }
        }

        private void panel_DriverTrip_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
