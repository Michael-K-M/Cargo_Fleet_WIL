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
    public partial class EmployeesHours : UserControl
    {
        List<string> EmpRole = new List<string>();
        List<string> EmpNames = new List<string>();
        DB_Connection db = new DB_Connection();
        String EmpRoles;
        String EmpName;
        string hours;

        double wage;

        // connecting to bd class
        int i = 0;
        Regex regex = new Regex(@"[^0-9qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ]");
        Regex regex2 = new Regex(@"[^0-9 ]");
        string badchar;

        public EmployeesHours()
        {
            InitializeComponent();
            DisplayEmpRole();

            //change in data insert
            DTP_Start.Format = DateTimePickerFormat.Custom;
            DTP_Start.CustomFormat = "HH:mm";


            DTP_End.Format = DateTimePickerFormat.Custom;
            DTP_End.CustomFormat = "HH:mm";
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
            //checks if textbox id null/blank

            if (string.IsNullOrEmpty(cb_Role.Text) || string.IsNullOrWhiteSpace(cb_Role.Text)||string.IsNullOrEmpty(cb_Name.Text) || string.IsNullOrWhiteSpace(cb_Name.Text)||string.IsNullOrEmpty(DTPDate.Text) || string.IsNullOrWhiteSpace(DTP_End.Text)||string.IsNullOrEmpty(tb_HourWage.Text) || string.IsNullOrWhiteSpace(tb_HourWage.Text)||string.IsNullOrEmpty(DTP_Start.Text) || string.IsNullOrWhiteSpace(DTP_Start.Text))
            {
                MessageBox.Show("Please ensure all information is provided");
            }
            else
            {
                DateTime startTime = Convert.ToDateTime(DTP_Start.Text);
                DateTime endTime = Convert.ToDateTime(DTP_End.Text);
                double RPH = Convert.ToInt32(tb_HourWage.Text);


                db.closeConnection();

                // save the employuee hours to db
                SqlCommand cmd = db.empRate();

                string date = DTPDate.Text;

                cmd.Parameters.Add("@Role", cb_Role.SelectedItem.ToString());
                cmd.Parameters.Add("@Name", cb_Name.SelectedItem.ToString());
                cmd.Parameters.Add("@StartTime", startTime.ToString());
                cmd.Parameters.Add("@EndTime", endTime.ToString());
                cmd.Parameters.Add("@RPH", Convert.ToDecimal(tb_HourWage.Text));
                cmd.Parameters.Add("@Date", date);
                hours = (endTime - startTime).TotalHours.ToString();
                wage = Convert.ToDouble(hours) * RPH;
                cmd.Parameters.Add("@Wage", Convert.ToDecimal(wage));
                //execute the save with into
                cmd.ExecuteNonQuery();

                //reset textbox
                cb_Role.ResetText();
                cb_Name.ResetText();
                DTP_Start.ResetText();
                DTP_End.ResetText();
                tb_HourWage.ResetText();
            }
        }

        //set combobox to index 0
        private void Cb_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Role.SelectedIndex != 0)
            {
                EmpRoles = EmpRole[cb_Role.SelectedIndex];
            }

            DisplayEmpName();

        }

        // desplay role inside the combobox with the positional role
        void DisplayEmpRole()
        {
            
            SqlDataReader myReader;
            try
            {
                db.closeConnection();
                myReader = db.FillEmpRole();
                EmpRole.Clear();
                while (myReader.Read())
                {
                    String sname = myReader.GetString(0); // index number

                    cb_Role.Items.Add(sname);
                    String test = myReader.ToString();
                    EmpRole.Add(test);

                   
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Cb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      //  desplay workers name depended on the combo box of positional role
        void DisplayEmpName()
        {

            SqlDataReader myReader;
            try
            {
                db.closeConnection();

                myReader = db.FillEmpName(cb_Role.SelectedItem.ToString());

                cb_Name.Items.Clear();

                while (myReader.Read())
                {
                    String sname = myReader.GetString(0); // index number

                    cb_Name.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTP_Start_ValueChanged(object sender, EventArgs e)
        {
            
        }
        ////////////////////// This activated the whitelisting to the combo boxs
        private void tb_HourWage_TextChanged(object sender, EventArgs e)
        {
            tb_HourWage.MaxLength = 255;
            badchar = inputMask2(tb_HourWage.Text);
            if (badchar == "1")
            {
                tb_HourWage.ResetText();
                MessageBox.Show("Sorry but you have entered Hourly Wage incorrectly . We do not comply to symbols ");

            }
        }
    }
    }

