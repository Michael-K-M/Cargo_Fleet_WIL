using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WILL_Project
{
    public partial class Login : Form
    {
        DB_Connection db = new DB_Connection();
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            // compare username and password with one in db
             DataTable dt = db.Login(tb_Username.Text, tb_Password.Text);

            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrWhiteSpace(tb_Username.Text))
            {
                MessageBox.Show("Sorry you entered no UserName");
            }
            else
            {
                if (string.IsNullOrEmpty(tb_Password.Text) || string.IsNullOrWhiteSpace(tb_Password.Text))
                {
                    MessageBox.Show("Sorry you entered no Password");
                }
                else
                {
                    // send user to location
                    if (dt.Rows.Count == 1)
                    {
                        switch (dt.Rows[0]["PossitionRole"] as string)
                        {
                            case "Office Manager":
                                {
                                    this.Hide();
                                    String ID = dt.Rows[0]["empID"].ToString();
                                    OfficeManager ss = new OfficeManager(ID); //parse the Primary key to the next class in the constructor
                                    ss.Show();
                                    break;
                                }

                            case "Vehicle Information Administrator":
                                {
                                    String ID = dt.Rows[0]["empID"].ToString();
                                    this.Hide();
                                    vehicleAdministrator mf = new vehicleAdministrator(ID);
                                    mf.Show();
                                    break;
                                }

                            case "Trip Manager":
                                {
                                    String ID = dt.Rows[0]["empID"].ToString();
                                    this.Hide();
                                    tripManager mf = new tripManager(ID);
                                    mf.Show();
                                    break;
                                }
                            case "Service Manager":
                                {
                                    String ID = dt.Rows[0]["empID"].ToString();
                                    this.Hide();
                                    serviceManager mf = new serviceManager(ID);
                                    mf.Show();
                                    break;
                                }
                            case "Timesheet Manager":
                                {
                                    String ID = dt.Rows[0]["empID"].ToString();
                                    this.Hide();
                                    timesheetManager mf = new timesheetManager(ID);
                                    mf.Show();
                                    break;
                                }

                            case "Driver":
                                {

                                    String ID = dt.Rows[0]["empID"].ToString();
                                    this.Hide();
                                    Driver mf = new Driver(ID);
                                    mf.Show();
                                    break;
                                }

                            case "Customer":
                                {

                                    String ID = dt.Rows[0]["empID"].ToString();
                                    this.Hide();
                                    Customer_Home mf = new Customer_Home(ID);
                                    mf.Show();
                                    break;
                                }

                            case "Mechanic":
                                {

                                    String ID = dt.Rows[0]["empID"].ToString();
                                    this.Hide();
                                    Mechanic mc = new Mechanic(ID);
                                    mc.Show();
                                    break;
                                }
                            default:
                                {
                                    // ... handle unexpected roles here...

                                    MessageBox.Show("wrong!");
                                    break;
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry but your username or password is incorrect");
                    }


                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.tb_Username.Size = new System.Drawing.Size(225, 27);
            //this.tb_Password.Size = new System.Drawing.Size(225, 27);

        }

        private void ll_CreateCustAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create_Customer cc = new Create_Customer();
            cc.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Testsdfgh test = new Testsdfgh();
            test.Show();
            this.Hide();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}