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
    public partial class Update_FuelCon : UserControl
    {

        DB_Connection db = new DB_Connection();

        string FuelID;
        string NP;
        double BT;
        double AT;
        double Price;

        public Update_FuelCon()
        {
            InitializeComponent();
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.LoadFuelCon());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                FuelID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_NP.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_BeforeTrip.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_AfterTrip.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


                NP = tb_NP.Text;
                BT = Convert.ToDouble(tb_BeforeTrip.Text);
                AT = Convert.ToDouble(tb_AfterTrip.Text);
                Price = Convert.ToDouble(tbPrice.Text);

            }
            catch (Exception)
            {

                tb_NP.Text = "";
                tb_BeforeTrip.Text = "";
                tb_AfterTrip.Text = "";
                tbPrice.Text = "";

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            // 
            SqlCommand cmd = db.UpdateFuelCon(tb_NP.Text, Convert.ToDouble(tb_BeforeTrip.Text), Convert.ToDouble(tb_AfterTrip.Text), Convert.ToDouble(tbPrice.Text), FuelID.ToString());

            cmd.Parameters.AddWithValue("@Number_Plate", tb_NP.Text);
            cmd.Parameters.AddWithValue("@L_B_T", tb_BeforeTrip.Text);
            cmd.Parameters.AddWithValue("@L_A_T", tb_AfterTrip.Text);
            cmd.Parameters.AddWithValue("@PPL", tbPrice.Text);

            cmd.ExecuteNonQuery();

            tb_NP.ResetText();
            tb_BeforeTrip.ResetText();
            tb_AfterTrip.ResetText();
            tbPrice.ResetText();
        }

        private void Bt_Remove_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            db.DeleteFuelCon(tb_NP.Text, FuelID.ToString());

            tb_NP.ResetText();
            tb_BeforeTrip.ResetText();
            tb_AfterTrip.ResetText();
            tbPrice.ResetText();
        }

        private void Update_FuelCon_Load(object sender, EventArgs e)
        {

        }
    }
}
