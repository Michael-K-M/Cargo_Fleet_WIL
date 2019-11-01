using System;
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
    public partial class Testsdfgh : Form
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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Z:\WILLProg\WILL_Project\WILL_Project\DataBase.mdf;Integrated Security=True");
        public Testsdfgh()
        {
            InitializeComponent();
            method();
        }

        private void Testsdfgh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dataBaseDataSet.Login);

        }

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            TbFN.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); 
            TbLN.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            TbDOB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            TbAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            TbUN.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            TbPW.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            TbPR.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            
            try
            {
                TbFN.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                TbLN.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                TbDOB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                TbAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                TbUN.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                TbPW.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                TbPR.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception)
            {

                TbFN.Text = "";
                TbLN.Text = "";
                TbDOB.Text = ""; 
                TbAddress.Text = "";
                TbUN.Text = "";
                TbPW.Text = "";
                TbPR.Text = "";
            }


        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void method()
        {
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.test());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            /*
          TbFN.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); 
          TbLN.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
          TbDOB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
          TbAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
          TbUN.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
          TbPW.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
          TbPR.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
          */
            try
            {
               UserID  = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_Surname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_DOB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_Address.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txt_username.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txt_password.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txt_role.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();


                 FirstName = txt_name.Text;
                 LastName = txt_Surname.Text;
                 DOB = txt_DOB.Text;
                 Address = txt_Address.Text;
                 Username = txt_username.Text;
                 Password = txt_password.Text;
                 Role = txt_role.Text;
            }
            catch (Exception)
            {

                txt_name.Text = "";
                txt_Surname.Text = "";
                txt_DOB.Text = "";
                txt_Address.Text = "";
                txt_username.Text = "";
                txt_password.Text = "";
                txt_role.Text = "";
            }


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            // FirstName
            SqlCommand cmd = db.updateLogin(txt_name.Text, txt_Surname.Text, txt_DOB.Text, txt_Address.Text, txt_username.Text, txt_password.Text,txt_role.Text, UserID.ToString());
            cmd.Parameters.AddWithValue("@FirstName", txt_name.Text);
            cmd.Parameters.AddWithValue("@LastName", txt_Surname.Text);
            cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@Username", txt_username.Text);
            cmd.Parameters.AddWithValue("@Password", txt_password.Text);
            cmd.Parameters.AddWithValue("@PossitionRole", txt_name.Text);

            cmd.ExecuteNonQuery();

        }
    }
}
