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
    public partial class Update_Emp_Rates : UserControl
    {

        DB_Connection db = new DB_Connection();
        int RateID;

        string role;
        string name;
        string starttime;
        string endtime;
        double RPH;
        string Date;

        public Update_Emp_Rates()
        {
            InitializeComponent();
            DisplayInfo();
        }
        public void DisplayInfo()
        {
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.LoadEmp_Rate());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            // 
            SqlCommand cmd = db.UpdateEmp_rate(Tb_Role.Text, Tb_Name.Text, Tb_Starttime.Text, Tb_EndTime.Text, Convert.ToDouble(Tb_RPH.Text), Tb_Date.Text, RateID.ToString());

            cmd.Parameters.AddWithValue("@Role", role);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@StartTime", starttime);
            cmd.Parameters.AddWithValue("@EndTime", endtime);
            cmd.Parameters.AddWithValue("@RPH", RPH);
            cmd.Parameters.AddWithValue("@Date", Date);

            cmd.ExecuteNonQuery();

            Tb_Role.ResetText();
            Tb_Name.ResetText();
            Tb_Starttime.ResetText();
            Tb_EndTime.ResetText();
            Tb_RPH.ResetText();
            Tb_Date.ResetText();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                RateID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Tb_Role.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Tb_Name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Tb_Starttime.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                Tb_EndTime.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Tb_RPH.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Tb_Date.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();



                role = Tb_Role.Text;
                name = Tb_Name.Text;
                starttime = Tb_Starttime.Text;
                endtime = Tb_EndTime.Text;
                RPH = Convert.ToDouble(Tb_RPH.Text);
                Date = Tb_Date.Text;

            }
            catch (Exception)
            {
                Tb_Role.Text = "";
                Tb_Name.Text = "";
                Tb_Starttime.Text = "";
                Tb_EndTime.Text = "";
                Tb_RPH.Text = "";
                Tb_Date.Text = "";


            }
        }

        private void Bt_Remove_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            db.DeleteEmp_Rate(Tb_Name.Text, RateID.ToString());

            Tb_Role.ResetText();
            Tb_Name.ResetText();
            Tb_Starttime.ResetText();
            Tb_EndTime.ResetText();
            Tb_RPH.ResetText();
            Tb_Date.ResetText();
        }

        private void Update_Emp_Rates_Load(object sender, EventArgs e)
        {

        }
    }
}
