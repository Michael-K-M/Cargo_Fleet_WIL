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
    public partial class AddVehicle : UserControl
    {
        DB_Connection db = new DB_Connection(); // connection to the bd class with methods

        int i = 0;

        // creating input whitelist
        Regex regex = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM .]");
        Regex regex2 = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM _]");
        string badchar;

        public AddVehicle()
        {
            InitializeComponent();
        }

        public string inputMask(string txb) // input method mask that filters
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

        private void Label_Capa_Click(object sender, EventArgs e)
        {

        }

        //checks if textbox id null/blank
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (tb_VMake.Text == "" || tb_VM.Text == "" || tb_VYear.Text == "" || tb_ES.Text == "" || tb_VIN.Text == "" || tb_NP.Text == "" || cb_capa.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {


                db.closeConnection();// close connectiion for new method in db class

                SqlCommand cmd = db.createVehicle(); // activate new method for saving a vehicle

                cmd.Parameters.Add("@Vehical_Make", tb_VMake.Text);
                cmd.Parameters.Add("@Vehical_Model", tb_VM.Text);
                cmd.Parameters.Add("@Vehical_Year", tb_VYear.Text);
                cmd.Parameters.Add("@VIN_Number", tb_VIN.Text);
                cmd.Parameters.Add("@Engine_Size", tb_ES.Text);
                cmd.Parameters.Add("@Number_Plate", tb_NP.Text);
                cmd.Parameters.Add("@Capacity", cb_capa.SelectedItem.ToString());

                cmd.ExecuteNonQuery();// initiate the save to db

                // reset textbox
                tb_VMake.ResetText();
                tb_VM.ResetText();
                tb_VYear.ResetText();
                tb_VIN.ResetText();
                tb_ES.ResetText();
                tb_NP.ResetText();
                cb_capa.ResetText();
            }

        }

        ////////////////////// This activated the whitelisting to the combo boxs
        
        private void tb_VMake_TextChanged(object sender, EventArgs e)
        {
            tb_VMake.MaxLength = 255;
            badchar = inputMask2(tb_VMake.Text);
            if (badchar == "1")
            {
                tb_VMake.ResetText();
                MessageBox.Show("Sorry but you have entered Vehicle Make incorrectly . We do not comply to symbols ");
            }
        }

        private void tb_VYear_TextChanged(object sender, EventArgs e)
        {
            tb_VYear.MaxLength = 255;
            badchar = inputMask(tb_VYear.Text);
            if (badchar == "1")
            {
                tb_VYear.ResetText();
                MessageBox.Show("Sorry but you have entered Year incorrectly . We do not comply to symbols ");
            }
        }

        private void tb_VIN_TextChanged(object sender, EventArgs e)
        {
            tb_VIN.MaxLength = 255;
            badchar = inputMask(tb_VIN.Text);
            if (badchar == "1")
            {
                tb_VIN.ResetText();
                MessageBox.Show("Sorry but you have entered VIN Number incorrectly . We do not comply to symbols ");
            }
        }

        private void tb_NP_TextChanged(object sender, EventArgs e)
        {
            tb_NP.MaxLength = 255;
            badchar = inputMask(tb_NP.Text);
            if (badchar == "1")
            {
                tb_NP.ResetText();
                MessageBox.Show("Sorry but you have entered Number Plate incorrectly . We do not comply to symbols ");
            }
        }

        private void tb_VM_TextChanged(object sender, EventArgs e)
        {
            tb_VM.MaxLength = 255;
            badchar = inputMask2(tb_VM.Text);
            if (badchar == "1")
            {
                tb_VM.ResetText();
                MessageBox.Show("Sorry but you have entered Vehicle Make incorrectly . We do not comply to symbols ");
            }
        }

        private void tb_ES_TextChanged(object sender, EventArgs e)
        {
            tb_ES.MaxLength = 255;
            badchar = inputMask(tb_ES.Text);
            if (badchar == "1")
            {
                tb_ES.ResetText();
                MessageBox.Show("Sorry but you have entered Engine Size incorrectly . We do not comply to symbols ");
            }
        }
    }
}
