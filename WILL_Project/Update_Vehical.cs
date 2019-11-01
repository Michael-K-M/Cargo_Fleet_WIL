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
    public partial class Update_Vehical : UserControl
    {
        DB_Connection db = new DB_Connection();
        String VehicleID;
        string Vehicle_Make;
        string Vehicle_Model;
        string Vehicle_Year;
        string VIN;
        string Engine_Size;
        string NP;
        string Capacity;
        string Status;
        string V_status;

        public Update_Vehical()
        {
            InitializeComponent();
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.LoadVehicals());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                VehicleID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_Make.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_Model.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_Year.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_VIN.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tb_EngineSize.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tb_NP.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tb_Capacity.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                tb_Status.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();


                Vehicle_Make = tb_Make.Text;
                Vehicle_Model = tb_Model.Text;
                Vehicle_Year = tb_Year.Text;
                VIN = tb_VIN.Text;
                Engine_Size = tb_EngineSize.Text;
                NP = tb_NP.Text;
                Capacity = tb_Capacity.Text;
                V_status = tb_Status.Text;
            }
            catch (Exception)
            {

                tb_Make.Text = "";
                tb_Model.Text = "";
                tb_Year.Text = "";
                tb_VIN.Text = "";
                tb_EngineSize.Text = "";
                tb_NP.Text = "";
                tb_Capacity.Text = "";
                tb_Status.Text = "";
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            // 
            SqlCommand cmd = db.UpdateVehicals(tb_Make.Text, tb_Model.Text, tb_Year.Text, tb_VIN.Text, tb_EngineSize.Text, tb_NP.Text, tb_Capacity.Text, tb_Status.Text, VehicleID.ToString());

            cmd.Parameters.AddWithValue("@FirstName", tb_Make.Text);
            cmd.Parameters.AddWithValue("@LastName", tb_Model.Text);
            cmd.Parameters.AddWithValue("@DOB", tb_Year.Text);
            cmd.Parameters.AddWithValue("@Address", tb_VIN.Text);
            cmd.Parameters.AddWithValue("@Username", tb_EngineSize.Text);
            cmd.Parameters.AddWithValue("@Password", tb_NP.Text);
            cmd.Parameters.AddWithValue("@PossitionRole", tb_Capacity.Text);
            cmd.Parameters.AddWithValue("@Status", tb_Status.Text);

            cmd.ExecuteNonQuery();

            tb_Make.ResetText();
            tb_Model.ResetText();
            tb_Year.ResetText();
            tb_VIN.ResetText();
            tb_EngineSize.ResetText();
            tb_NP.ResetText();
            tb_Capacity.ResetText();
            tb_Status.ResetText();
        }
    }
}
