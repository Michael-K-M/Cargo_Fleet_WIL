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
    public partial class VA_VehicleStatus : UserControl
    {
        DB_Connection db = new DB_Connection(); // connecting to bd class
        public VA_VehicleStatus()
        {
            InitializeComponent();
        }

        private void Btn_SV_Click(object sender, EventArgs e)
        {
            // desplay vehicles that are not being used
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.StatVehicleSta());
            da.Fill(dt);
            DGV_TripStatus.DataSource = dt;
             
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // desplay vehicles that are in use
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.StatVehicleAct());
            da.Fill(dt);
            DGV_TripStatus.DataSource = dt;
        }

        private void btn_InService_Click(object sender, EventArgs e)
        {
            // desplay vehicles that are in a service
            db.closeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.StatVehicleSer());
            da.Fill(dt);
            DGV_TripStatus.DataSource = dt;
        }
    }
}
