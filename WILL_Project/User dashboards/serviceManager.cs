﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WILL_Project
{
    public partial class serviceManager : Form
    {
        DB_Connection db = new DB_Connection();
        String UserID;
        public serviceManager(String id)
        {
            this.UserID = id;
            InitializeComponent();
            DisplayName();
        }

        void DisplayName()
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataReader myReader;
            try
            {
                db.closeConnection();

                myReader = db.DisplayStaffName(UserID);

                while (myReader.Read())
                {
                    String FirstName = myReader.GetString(0);
                    String LastName = myReader.GetString(1);

                    label_Names.Text = FirstName + " " + LastName;
                    // tb_LastName.Text = LastName;
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            /*Login fm = new Login();
            this.Hide();
            fm.Show();*/
            Application.Exit();
        }

        private void Btn_AddService_Click(object sender, EventArgs e)
        {
            AddService add = new AddService();
            panel_SM.Controls.Clear();
            panel_SM.Controls.Add(add);
        }

        private void Btn_AIS_Click(object sender, EventArgs e)
        {
            IncidentService IS = new IncidentService();
            panel_SM.Controls.Clear();
            panel_SM.Controls.Add(IS);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}