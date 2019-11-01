using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WILL_Project
{
    public partial class Report_vehicle : UserControl
    {
        DB_Connection db = new DB_Connection();
        
        DataTable AllVehicles;

        public Report_vehicle()
        {
            InitializeComponent();
        }
        void All_Vehicles()
        {
            db.closeConnection();

            DataTable dt = new DataTable();
            //Role, Name, RPH, StartTime, EndTime, Date, TotalWage
            dt.Columns.Add("Vehicle Make", typeof(String));
            dt.Columns.Add("Vehicle Model", typeof(String));
            dt.Columns.Add("Vehicle Year", typeof(String));
            dt.Columns.Add("VIN Number", typeof(String));
            dt.Columns.Add("Engine Size", typeof(String));
            dt.Columns.Add("Number Plate", typeof(String));
            dt.Columns.Add("Capacity", typeof(String));

            AllVehicles = db.ViewAllVehicles();

            for (int i = 0; i < AllVehicles.Rows.Count; i++)
            {

                string V_Make = AllVehicles.Rows[i][1].ToString();
                string V_Model = AllVehicles.Rows[i][2].ToString();
                string V_Year = AllVehicles.Rows[i][3].ToString();
                string VIN_Num = AllVehicles.Rows[i][4].ToString();
                string Engine_Size = AllVehicles.Rows[i][5].ToString();
                string NP = AllVehicles.Rows[i][6].ToString();
                string Capacity = AllVehicles.Rows[i][7].ToString();

                dt.Rows.Add(V_Make, V_Model, V_Year, VIN_Num, Engine_Size, NP, Capacity);

                dg_vehicle_report.DataSource = dt;
            }
        }

        void Pending_Service()
        {
            db.closeConnection();

            DataTable dt = new DataTable();
            //Role, Name, RPH, StartTime, EndTime, Date, TotalWage
            dt.Columns.Add("Vehicle Make", typeof(String));
            dt.Columns.Add("Vehicle Model", typeof(String));
            dt.Columns.Add("Number Plate", typeof(String));
            dt.Columns.Add("Total Milage", typeof(String));
            dt.Columns.Add("Date Of Service", typeof(String));
            dt.Columns.Add("Problem Description", typeof(String));

            AllVehicles = db.ViewServiceAppointment();

            for (int i = 0; i < AllVehicles.Rows.Count; i++)
            {

                string V_Make = AllVehicles.Rows[i][1].ToString();
                string V_Model = AllVehicles.Rows[i][2].ToString();
                string NP = AllVehicles.Rows[i][3].ToString();
                string Total_Milage = AllVehicles.Rows[i][4].ToString();
                string Date = AllVehicles.Rows[i][5].ToString();
                string Problem = AllVehicles.Rows[i][6].ToString();

                dt.Rows.Add(V_Make, V_Model, NP, Total_Milage, Date, Problem);

                dg_vehicle_report.DataSource = dt;
            }
        }
        void Complete_Service()
        {
            db.closeConnection();

            DataTable dt = new DataTable();
            //s.Vehicle_Make, s.Vehicle_Model, s.Number_Plate, cs.Description, cs.Price
            dt.Columns.Add("Vehicle Make", typeof(String));
            dt.Columns.Add("Vehicle Model", typeof(String));
            dt.Columns.Add("Number Plate", typeof(String));
            dt.Columns.Add("Replacement Required", typeof(String));
            dt.Columns.Add("Total price", typeof(String));
            

            AllVehicles = db.ViewCompleteService();

            for (int i = 0; i < AllVehicles.Rows.Count; i++)
            {

                string V_Make = AllVehicles.Rows[i][0].ToString();
                string V_Model = AllVehicles.Rows[i][1].ToString();
                string NP = AllVehicles.Rows[i][2].ToString();
                string Description = AllVehicles.Rows[i][3].ToString();
                string Total_Price = AllVehicles.Rows[i][4].ToString();

                dt.Rows.Add(V_Make, V_Model, NP, Description, Total_Price);

                dg_vehicle_report.DataSource = dt;
            }
        }
        private void Btn_View_all_vehicles_Click(object sender, EventArgs e)
        {
            All_Vehicles();
        }

        private void Btn_vehicles_booked_service_Click(object sender, EventArgs e)
        {
            Pending_Service();
        }

        private void Btn_vehicles_service_complete_Click(object sender, EventArgs e)
        {
            Complete_Service();
        }
    }
}
