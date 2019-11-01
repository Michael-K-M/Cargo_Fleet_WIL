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
    
    public partial class OM_ViewTrips : UserControl
    {

         DB_Connection db = new DB_Connection(); // db connection 

        public OM_ViewTrips()
        {
            InitializeComponent();
        }

        //display active trip
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            db.closeConnection();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.Active());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // desplay pending trip
        private void Button1_Click(object sender, EventArgs e)
        {

            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.Pending());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // display complete trip
        private void Btn_Complete_Click(object sender, EventArgs e)
        {

            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.Complete());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void OM_ViewTrips_Load(object sender, EventArgs e)
        {

        }
    }
}
