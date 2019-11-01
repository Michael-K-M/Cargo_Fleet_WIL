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
    public partial class CreateTrip : UserControl
    {
        DB_Connection db = new DB_Connection();// connecting to bd class
        
        // creating input whitelist
        int i = 0;
        Regex regex = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM .,]");
        Regex regex2 = new Regex(@"[^0-9 ]");
        string badchar;

        public CreateTrip()
        {
            InitializeComponent();
            cb_SProv.SelectedIndex = 0; // set dropdown to index 1
            cb_RProv.SelectedIndex = 0; // set dropdown to index 1
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
        // input method mask that filters
        public string inputMask2(string txb)
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

        private void Btn_Create_Click(object sender, EventArgs e)
        {
           
        }

        private void CreateTrip_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click_1(object sender, EventArgs e)
        {
            //checks if textbox id null/blank
            if (tb_SenderName.Text == "" || tb_SenderSA.Text == "" || tb_SenderCity.Text == "" || tb_senderPC.Text == "" || cb_SProv.SelectedItem.ToString() == "--Select Porovince--" || tb_SenderPhone.Text == "" ||
              tb_RName.Text == "" || R_SAddress.Text == "" || tb_RTown.Text == "" || tb_RPostcode.Text == "" || cb_RProv.SelectedItem.ToString() == "--Select Porovince--" || tb_RPhone.Text == "" || tb_RDesc.Text == "")
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {


                db.closeConnection();

                // this will save the trip to the db
                SqlCommand cmd = db.createTrip();

                cmd.Parameters.Add("@S_Name", tb_SenderName.Text);
                cmd.Parameters.Add("@S_StreetAddress", tb_SenderSA.Text);
                cmd.Parameters.Add("@S_City", tb_SenderCity.Text);
                cmd.Parameters.Add("@S_Postcode", tb_senderPC.Text);
                cmd.Parameters.Add("@S_Province", cb_SProv.SelectedItem.ToString());
                cmd.Parameters.Add("@S_Phone", tb_SenderPhone.Text);

                cmd.Parameters.Add("@R_Name", tb_RName.Text);
                cmd.Parameters.Add("@R_StreetAddress", R_SAddress.Text);
                cmd.Parameters.Add("@R_City", tb_RTown.Text);
                cmd.Parameters.Add("@R_Postcode", tb_RPostcode.Text);
                cmd.Parameters.Add("@R_Province", cb_RProv.SelectedItem.ToString());
                cmd.Parameters.Add("@R_Phone", tb_RPhone.Text);
                cmd.Parameters.Add("@R_Description", tb_RDesc.Text);
                cmd.ExecuteNonQuery();

                //this will reset the textbox
                tb_SenderName.ResetText();
                tb_SenderSA.ResetText();
                tb_SenderCity.ResetText();
                tb_senderPC.ResetText();
                cb_SProv.ResetText();
                tb_SenderPhone.ResetText();

                tb_RName.ResetText();
                R_SAddress.ResetText();
                tb_RTown.ResetText();
                tb_RPostcode.ResetText();
                cb_RProv.ResetText();
                tb_RPhone.ResetText();
                tb_RDesc.ResetText();
            }

        }
        ////////////////////// This activated the whitelisting to the combo boxs
        private void tb_SenderName_TextChanged(object sender, EventArgs e)
        {
            tb_SenderName.MaxLength = 255;
            badchar = inputMask(tb_SenderName.Text);
            if (badchar == "1")
            {
                tb_SenderName.ResetText();
                MessageBox.Show("Sorry but you have entered Sending Location incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_SenderSA_TextChanged(object sender, EventArgs e)
        {
            tb_SenderSA.MaxLength = 255;
            badchar = inputMask(tb_SenderSA.Text);
            if (badchar == "1")
            {
                tb_SenderSA.ResetText();
                MessageBox.Show("Sorry but you have entered Street Address incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_SenderCity_TextChanged(object sender, EventArgs e)
        {
            tb_SenderCity.MaxLength = 255;
            badchar = inputMask(tb_SenderCity.Text);
            if (badchar == "1")
            {
                tb_SenderCity.ResetText();
                MessageBox.Show("Sorry but you have entered City / Town incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_senderPC_TextChanged(object sender, EventArgs e)
        {
            tb_senderPC.MaxLength = 255;
            badchar = inputMask(tb_senderPC.Text);
            if (badchar == "1")
            {
                tb_senderPC.ResetText();
                MessageBox.Show("Sorry but you have entered Postalcode incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_SenderPhone_TextChanged(object sender, EventArgs e)
        {
            tb_SenderPhone.MaxLength = 10;
            badchar = inputMask2(tb_SenderPhone.Text);
            if (badchar == "1")
            {
                tb_SenderPhone.ResetText();
                MessageBox.Show("Sorry but you have entered Contact Details incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_RName_TextChanged(object sender, EventArgs e)
        {
            tb_RName.MaxLength = 255;
            badchar = inputMask(tb_RName.Text);
            if (badchar == "1")
            {
                tb_RName.ResetText();
                MessageBox.Show("Sorry but you have entered Receiving Location incorrectly . We do not comply to symbols ");

            }
        }

        private void R_SAddress_TextChanged(object sender, EventArgs e)
        {
            R_SAddress.MaxLength = 255;
            badchar = inputMask(R_SAddress.Text);
            if (badchar == "1")
            {
                R_SAddress.ResetText();
                MessageBox.Show("Sorry but you have entered Street Address incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_RTown_TextChanged(object sender, EventArgs e)
        {
            tb_RTown.MaxLength = 255;
            badchar = inputMask(tb_RTown.Text);
            if (badchar == "1")
            {
                tb_RTown.ResetText();
                MessageBox.Show("Sorry but you have entered City / Town incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_RPostcode_TextChanged(object sender, EventArgs e)
        {
            tb_RPostcode.MaxLength = 255;
            badchar = inputMask(tb_RPostcode.Text);
            if (badchar == "1")
            {
                tb_RPostcode.ResetText();
                MessageBox.Show("Sorry but you have entered Postalcode incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_RDesc_TextChanged(object sender, EventArgs e)
        {
            tb_RDesc.MaxLength = 255;
            badchar = inputMask(tb_RDesc.Text);
            if (badchar == "1")
            {
                tb_RDesc.ResetText();
                MessageBox.Show("Sorry but you have entered your Description incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_RPhone_TextChanged(object sender, EventArgs e)
        {
            tb_RPhone.MaxLength = 10;
            badchar = inputMask2(tb_RPhone.Text);
            if (badchar == "1")
            {
                tb_RPhone.ResetText();
                MessageBox.Show("Sorry but you have entered Contact Number incorrectly . We do not comply to symbols ");

            }
        }
    }
}
