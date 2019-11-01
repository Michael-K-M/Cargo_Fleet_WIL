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
    public partial class FuelCon : UserControl
    {
        DB_Connection db = new DB_Connection(); // connecting to bd class

        List<string> EmpRole = new List<string>();
        String EmpRoles;

        // creating input whitelist
        int i = 0;
        Regex regex = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ,]");
        string badchar;

        public FuelCon()
        {
            InitializeComponent();
            DisplayEmpRole();
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

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_NP.Text) || string.IsNullOrWhiteSpace(cb_NP.Text)||string.IsNullOrEmpty(tb_Before.Text) || string.IsNullOrWhiteSpace(tb_Before.Text)||string.IsNullOrEmpty(tb_After.Text) || string.IsNullOrWhiteSpace(tb_After.Text)||string.IsNullOrEmpty(tb_Price.Text) || string.IsNullOrWhiteSpace(tb_Price.Text))
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {


                db.closeConnection();

                // save input to DB for hours worked
                SqlCommand cmd = db.FuelCon();
                cmd.Parameters.Add("@Number_Plate", cb_NP.SelectedItem.ToString());
                cmd.Parameters.Add("@L_B_T", Convert.ToDecimal(tb_Before.Text));
                cmd.Parameters.Add("@L_A_T", Convert.ToDecimal(tb_After.Text));
                cmd.Parameters.Add("@PPL", Convert.ToDecimal(tb_Price.Text));

                cmd.ExecuteNonQuery();

                //reset textbox
                cb_NP.ResetText();
                tb_Before.ResetText();
                tb_After.ResetText();
                tb_Price.ResetText();
            }
        }

        private void Cb_NP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_NP.SelectedIndex != 0)
            {
                EmpRoles = EmpRole[cb_NP.SelectedIndex];
            }
        }

        //desplay positional role in combobox
        void DisplayEmpRole()
        {

            SqlDataReader myReader;
            try
            {
                db.closeConnection();
                myReader = db.FillNP();
                EmpRole.Clear();
                while (myReader.Read())
                {
                    String sname = myReader.GetString(0); // index number

                    cb_NP.Items.Add(sname);
                    String test = myReader.ToString();
                    EmpRole.Add(test);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        ////////////////////// This activated the whitelisting to the combo boxs
        private void tb_Before_TextChanged(object sender, EventArgs e)
        {
            tb_Before.MaxLength = 255;
            badchar = inputMask(tb_Before.Text);
            if (badchar == "1")
            {
                tb_Before.ResetText();
                MessageBox.Show("Sorry but you have entered Liters Filled Before Trip incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_After_TextChanged(object sender, EventArgs e)
        {
            tb_After.MaxLength = 255;
            badchar = inputMask(tb_After.Text);
            if (badchar == "1")
            {
                tb_After.ResetText();
                MessageBox.Show("Sorry but you have entered Litters Filled After Trip incorrectly . We do not comply to symbols ");

            }
        }

        private void tb_Price_TextChanged(object sender, EventArgs e)
        {
            tb_Price.MaxLength = 255;
            badchar = inputMask(tb_Price.Text);
            if (badchar == "1")
            {
                tb_Price.ResetText();
                MessageBox.Show("Sorry but you have entered the Current Fuel Price incorrectly . We do not comply to symbols ");

            }
        }
    }
}
