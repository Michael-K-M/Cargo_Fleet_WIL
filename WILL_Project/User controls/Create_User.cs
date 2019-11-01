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
using System.Text.RegularExpressions;

namespace WILL_Project
{
    public partial class Create_User : UserControl
    {
        DB_Connection db = new DB_Connection(); // connecting to bd class

        int i = 0;
        // creating input whitelist
        Regex regex = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ]");
        Regex regex2 = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ,]");
        string badchar;
        DataTable Username;

        public Create_User()
        {
            InitializeComponent();
            cb_Possition.SelectedIndex = 0;
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

        private void Btn_Back_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Create_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Create_User_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            db.closeConnection();
            //checks if textbox id null/blank

            if (tb_FirstName.Text == "" || tb_LastName.Text == "" || DTP_Age.Text == "" || tb_Address.Text == "" ||
                tb_Username.Text == "" || tb_Password.Text == "" || cb_Possition.SelectedItem.ToString() == "--Select--")
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {

                db.closeConnection();
                Username = db.LoginUsername(tb_Username.Text);

                if (Username.Rows.Count > 0)
                {
                    MessageBox.Show("Sorry but your Username has already been taken");
                }

                else
                {

                    db.closeConnection();

                    // this function will add to the DB
                    SqlCommand cmd = db.create();


                    cmd.Parameters.Add("@FirstName", tb_FirstName.Text);
                    cmd.Parameters.Add("@LastName", tb_LastName.Text);
                    cmd.Parameters.Add("@DOB", DTP_Age.Text);
                    cmd.Parameters.Add("@Address", tb_Address.Text);
                    cmd.Parameters.Add("@Username", tb_Username.Text);
                    cmd.Parameters.Add("@Password", tb_Password.Text);
                    cmd.Parameters.Add("@PossitionRole", cb_Possition.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();

                    //reset textbox
                    tb_FirstName.ResetText();
                    tb_LastName.ResetText();
                    DTP_Age.ResetText();
                    tb_Address.ResetText();
                    tb_Username.ResetText();
                    tb_Password.ResetText();
                    cb_Possition.ResetText();

                }

            }
        }

        private void Tb_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void DTP_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        ////////////////////// This activated the whitelisting to the combo boxs
        private void tb_LastName_TextChanged(object sender, EventArgs e)
        {
            tb_LastName.MaxLength = 255;
            badchar = inputMask(tb_LastName.Text);
            if (badchar == "1")
            {
                tb_LastName.ResetText();
                MessageBox.Show("Sorry but you have entered Lastname incorrectly . We do not comply to symbols ");
            }

        }

        private void tb_Address_TextChanged(object sender, EventArgs e)
        {
            tb_Address.MaxLength = 255;
            badchar = inputMask2(tb_Address.Text);
            if (badchar == "1")
            {
                tb_Address.ResetText();
                MessageBox.Show("Sorry but you have entered Address incorrectly . We do not comply to symbols ");
            }


        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Username.MaxLength = 255;
            badchar = inputMask(tb_Username.Text);
            if (badchar == "1")
            {
                tb_Username.ResetText();
                MessageBox.Show("Sorry but you have entered Username incorrectly . We do not comply to symbols ");
            }

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            tb_Password.MaxLength = 255;
            badchar = inputMask(tb_Password.Text);
            if (badchar == "1")
            {
                tb_Password.ResetText();
                MessageBox.Show("Sorry but you have entered Password incorrectly . We do not comply to symbols ");

            }
        }

        private void cb_Possition_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_Possition_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void tb_FirstName_TextChanged(object sender, EventArgs e)
        {
            tb_FirstName.MaxLength = 255;
            badchar = inputMask(tb_FirstName.Text);
            if (badchar == "1")
            {
                tb_FirstName.ResetText();
                MessageBox.Show("Sorry but you have entered Firstname incorrectly . We do not comply to symbols ");
            }
        }

        private void DTP_Age_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

