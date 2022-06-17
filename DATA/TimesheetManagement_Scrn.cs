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

namespace FLEET_SYSTEM1._0
{
    public partial class TimesheetManagement_Scrn : UserControl
    {
        public TimesheetManagement_Scrn()
        {
            InitializeComponent();
        }

        private void TimesheetManagement_Scrn_Load(object sender, EventArgs e)
        {
            //Defining the columns 
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Timesheet Unique Id");
            myTable.Columns.Add("Employee Id");
            myTable.Columns.Add("Company Id");
            myTable.Columns.Add("Date Worked");
            myTable.Columns.Add("Hours Worked");
            myTable.Columns.Add("Overtime Worked");

            //getting the values from the database
            SqlDataAdapter adp = new SqlDataAdapter("select * from Timesheet", Connection.connect);

            DataTable dt = new DataTable();
            adp.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = myTable.NewRow();
                dr[0] = dt.Rows[i][0];
                dr[1] = dt.Rows[i][1];
                dr[2] = dt.Rows[i][2];
                dr[3] = dt.Rows[i][3];
                dr[4] = dt.Rows[i][4];
                dr[5] = dt.Rows[i][5];

                //MessageBox.Show(dt.Rows[i][0].ToString() + dt.Rows[i][1].ToString() + dt.Rows[i][2].ToString() + dt.Rows[i][3].ToString() + dt.Rows[i][4].ToString());

                //add the row 
                myTable.Rows.Add(dr);
            }        


            myGrid.DataSource = myTable;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string id = txtQuick.Text;           

            //Defining the columns 
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Timesheet Unique Id");
            myTable.Columns.Add("Employee Id");
            myTable.Columns.Add("Company Id");
            myTable.Columns.Add("Date Worked");
            myTable.Columns.Add("Hours Worked");
            myTable.Columns.Add("Overtime Worked");

            //getting the values from the database
            SqlDataAdapter adp = new SqlDataAdapter("select * from Timesheet where EmployeeID LIKE '%" + id + "%' OR TimesheetID LIKE '%"+ id +"%'", Connection.connect);

            DataTable dt = new DataTable();
            adp.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = myTable.NewRow();
                dr[0] = dt.Rows[i][0];
                dr[1] = dt.Rows[i][1];
                dr[2] = dt.Rows[i][2];
                dr[3] = dt.Rows[i][3];
                dr[4] = dt.Rows[i][4];
                dr[5] = dt.Rows[i][5];

                //MessageBox.Show(dt.Rows[i][0].ToString() + dt.Rows[i][1].ToString() + dt.Rows[i][2].ToString() + dt.Rows[i][3].ToString() + dt.Rows[i][4].ToString());

                //add the row 
                myTable.Rows.Add(dr);
            }


            myGrid.DataSource = myTable;
        }

        private void btnEmpSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;

            //Defining the columns 
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Timesheet Unique Id");
            myTable.Columns.Add("Employee Id");
            myTable.Columns.Add("Company Id");
            myTable.Columns.Add("Date Worked");
            myTable.Columns.Add("Hours Worked");
            myTable.Columns.Add("Overtime Worked");

            string query = "select Timesheet.TimesheetID, Timesheet.EmployeeID, Timesheet.CompanyID, Timesheet.Day, Timesheet.Hours, Timesheet.Overtime " +
                "from Timesheet, Employees " +
                "where Timesheet.EmployeeID = Employees.EmployeeID And " +
                "Employees.EmployeeName = '" + name + "' OR Employees.EmployeeSurname = '" + surname + "';" ;

            SqlDataAdapter adp = new SqlDataAdapter(query, Connection.connect);

            DataTable dt = new DataTable();
            adp.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = myTable.NewRow();
                dr[0] = dt.Rows[i][0];
                dr[1] = dt.Rows[i][1];
                dr[2] = dt.Rows[i][2];
                dr[3] = dt.Rows[i][3];
                dr[4] = dt.Rows[i][4];
                dr[5] = dt.Rows[i][5];

                //MessageBox.Show(dt.Rows[i][0].ToString() + dt.Rows[i][1].ToString() + dt.Rows[i][2].ToString() + dt.Rows[i][3].ToString() + dt.Rows[i][4].ToString());

                //add the row 
                myTable.Rows.Add(dr);
            }


            myGrid.DataSource = myTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtQuick.Clear();
        }
    }
}
