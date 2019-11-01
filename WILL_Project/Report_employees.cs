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
    public partial class Report_employees : UserControl
    {

        DB_Connection db = new DB_Connection();
        DataTable Emp_Report;

        public Report_employees()
        {
            InitializeComponent();
        }

        public void Emp_Rate()
        {
            db.closeConnection();

            DataTable dt = new DataTable();
            //Role, Name, RPH, StartTime, EndTime, Date, TotalWage
            dt.Columns.Add("Role", typeof(String));
            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Hourly Rate", typeof(String));
            dt.Columns.Add("Start Time", typeof(String));
            dt.Columns.Add("End Time", typeof(String));
            dt.Columns.Add("Date", typeof(String));
            dt.Columns.Add("Total Wage", typeof(String));

            Emp_Report = db.EmployeeReport();

            for (int i = 0; i < Emp_Report.Rows.Count; i++)
            {
                
                    string Role = Emp_Report.Rows[i][0].ToString();
                    string Name = Emp_Report.Rows[i][1].ToString();
                    string HourlyRate = Emp_Report.Rows[i][2].ToString();
                    string StartTime = Emp_Report.Rows[i][3].ToString();
                    string EndTime = Emp_Report.Rows[i][4].ToString();
                string Date = Emp_Report.Rows[i][5].ToString();
                string TotalWage = Emp_Report.Rows[i][6].ToString();

                dt.Rows.Add(Role, Name, HourlyRate, StartTime, EndTime, Date, TotalWage);

                    dg_emp_report.DataSource = dt;
                }
            }
        

        private void btn_View_emp_rates_Click(object sender, EventArgs e)
        {
            Emp_Rate();
        }
    }
}
