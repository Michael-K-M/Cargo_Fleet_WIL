using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WILL_Project
{
    public partial class Update_Service : UserControl
    {
        DB_Connection db = new DB_Connection();
        string ServiceID;
        string VMake;
        string VModel;
        string NP;
        string Milage;
        string Date;
        string Prob;
        string Status;

        public Update_Service()
        {
            InitializeComponent();
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.LoadService());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ServiceID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_VMak.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_VModel.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_NP.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_Milage.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tb_Date.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tb_Problem.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tb_Status.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();


                VMake = tb_VMak.Text;
                VModel = tb_VModel.Text;
                NP = tb_NP.Text;
                Milage = tb_Milage.Text;
                Date = tb_Date.Text;
                Prob = tb_Problem.Text;
                Status = tb_Status.Text;
            }
            catch (Exception)
            {

                tb_VMak.Text = "";
                tb_VModel.Text = "";
                tb_NP.Text = "";
                tb_Milage.Text = "";
                tb_Date.Text = "";
                tb_Problem.Text = "";
                tb_Status.Text = "";
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            // 
            SqlCommand cmd = db.UpdateService(tb_VMak.Text, tb_VModel.Text, tb_NP.Text, tb_Milage.Text, tb_Date.Text, tb_Problem.Text, tb_Status.Text, ServiceID.ToString());

            cmd.Parameters.AddWithValue("@Vehicle_Make", tb_VMak.Text);
            cmd.Parameters.AddWithValue("@Vehicle_Model", tb_VModel.Text);
            cmd.Parameters.AddWithValue("@Number_Plate", tb_NP.Text);
            cmd.Parameters.AddWithValue("@Total_Milage", tb_Milage.Text);
            cmd.Parameters.AddWithValue("@Date", tb_Date.Text);
            cmd.Parameters.AddWithValue("@Problem", tb_Problem.Text);
            cmd.Parameters.AddWithValue("@Status", tb_Status.Text);

            cmd.ExecuteNonQuery();

            tb_VMak.ResetText();
            tb_VModel.ResetText();
            tb_NP.ResetText();
            tb_Milage.ResetText();
            tb_Date.ResetText();
            tb_Problem.ResetText();
            tb_Status.ResetText();
        }

        private void Bt_Remove_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            db.DeleteService(tb_VMak.Text, ServiceID.ToString());

            tb_VMak.ResetText();
            tb_VModel.ResetText();
            tb_NP.ResetText();
            tb_Milage.ResetText();
            tb_Date.ResetText();
            tb_Problem.ResetText();
            tb_Status.ResetText();

        }
    }
}
