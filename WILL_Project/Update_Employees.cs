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
    public partial class Update_Employees : UserControl
    {
        DB_Connection db = new DB_Connection();

        String UserID;
        string FirstName;
        string LastName;
        string DOB;
        string Address;
        string Username;
        string Password;
        string Role;

        public Update_Employees()
        {
            InitializeComponent();
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.LoadEmployees());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                UserID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_Firstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_Surename.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_DOB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_Address.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tb_Username.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tb_Password.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tb_Role.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();


                FirstName = tb_Firstname.Text;
                LastName = tb_Surename.Text;
                DOB = tb_DOB.Text;
                Address = tb_Address.Text;
                Username = tb_Username.Text;
                Password = tb_Password.Text;
                Role = tb_Role.Text;
            }
            catch (Exception)
            {

                tb_Firstname.Text = "";
                tb_Surename.Text = "";
                tb_DOB.Text = "";
                tb_Address.Text = "";
                tb_Username.Text = "";
                tb_Password.Text = "";
                tb_Role.Text = "";
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            // 
            SqlCommand cmd = db.UpdateEmployees(tb_Firstname.Text, tb_Surename.Text, tb_DOB.Text, tb_Address.Text, tb_Username.Text, tb_Password.Text, tb_Role.Text, UserID.ToString());

            cmd.Parameters.AddWithValue("@FirstName", tb_Firstname.Text);
            cmd.Parameters.AddWithValue("@LastName", tb_Surename.Text);
            cmd.Parameters.AddWithValue("@DOB", tb_DOB.Text);
            cmd.Parameters.AddWithValue("@Address", tb_Address.Text);
            cmd.Parameters.AddWithValue("@Username", tb_Username.Text);
            cmd.Parameters.AddWithValue("@Password", tb_Password.Text);
            cmd.Parameters.AddWithValue("@PossitionRole", tb_Role.Text);
            cmd.ExecuteNonQuery();

            tb_Firstname.ResetText();
            tb_Surename.ResetText();
            tb_DOB.ResetText();
            tb_Address.ResetText();
            tb_Username.ResetText();
            tb_Password.ResetText();
            tb_Role.ResetText();
        }

        private void Bt_Remove_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            db.DeleteLogin(tb_Firstname.Text, UserID.ToString());

            tb_Firstname.ResetText();
            tb_Surename.ResetText();
            tb_DOB.ResetText();
            tb_Address.ResetText();
            tb_Username.ResetText();
            tb_Password.ResetText();
            tb_Role.ResetText();
        }
    }
}
