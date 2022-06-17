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
    public partial class TripsAndUsage_Scrn : UserControl
    {
        public TripsAndUsage_Scrn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTrips_Daily_Click(object sender, EventArgs e)
        {

        }

        private void TripsAndUsage_Scrn_Load(object sender, EventArgs e)
        {
            //Columns
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Trip-log ID");
            myTable.Columns.Add("Description");
            myTable.Columns.Add("Arrival Time");
            myTable.Columns.Add("Location");
            myTable.Columns.Add("Driver Name");

            //getting
            SqlDataAdapter adp = new SqlDataAdapter("select TripLog.TripLogID, Orders.OrderDescription, Orders.OrderArrivalTime, Orders.OrderLocation, Drivers.DriverName from Orders, Drivers, TripLog where Orders.OrderID = TripLog.OrderID and Drivers.DriverID = TripLog.DriverID", Connection.connect);
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

                myTable.Rows.Add(dr);
            }

            tripGrid.DataSource = myTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Columns
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Trip-log ID");
            myTable.Columns.Add("Description");
            myTable.Columns.Add("Arrival Time");
            myTable.Columns.Add("Location");
            myTable.Columns.Add("Driver Name");

            //getting
            SqlDataAdapter adp = new SqlDataAdapter("select TripLog.TripLogID, Orders.OrderDescription, Orders.OrderArrivalTime, Orders.OrderLocation, Drivers.DriverName from Orders, Drivers, TripLog where Orders.OrderID = TripLog.OrderID and Drivers.DriverID = TripLog.DriverID and TripLog.TripLogID = '" + txtTimesheetID.Text +"'", Connection.connect);
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

                myTable.Rows.Add(dr);
            }

            tripGrid.DataSource = myTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Columns
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Trip-log ID");
            myTable.Columns.Add("Description");
            myTable.Columns.Add("Arrival Time");
            myTable.Columns.Add("Location");
            myTable.Columns.Add("Driver Name");

            //getting
            SqlDataAdapter adp = new SqlDataAdapter("select TripLog.TripLogID, Orders.OrderDescription, Orders.OrderArrivalTime, Orders.OrderLocation, Drivers.DriverName from Orders, Drivers, TripLog where Orders.OrderID = TripLog.OrderID and Drivers.DriverID = TripLog.DriverID and TripLog.TripLogID = '" + txtEmployeeID.Text + "'", Connection.connect);
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

                myTable.Rows.Add(dr);
            }

            tripGrid.DataSource = myTable;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Columns
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Trip-log ID");
            myTable.Columns.Add("Description");
            myTable.Columns.Add("Arrival Time");
            myTable.Columns.Add("Location");
            myTable.Columns.Add("Driver Name");

            //getting
            SqlDataAdapter adp = new SqlDataAdapter("select TripLog.TripLogID, Orders.OrderDescription, Orders.OrderArrivalTime, Orders.OrderLocation, Drivers.DriverName from Orders, Drivers, TripLog where Orders.OrderID = TripLog.OrderID and Drivers.DriverID = TripLog.DriverID", Connection.connect);
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

                myTable.Rows.Add(dr);
            }

            tripGrid.DataSource = myTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Columns
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Trip-log ID");
            myTable.Columns.Add("Description");
            myTable.Columns.Add("Arrival Time");
            myTable.Columns.Add("Location");
            myTable.Columns.Add("Driver Name");

            //getting
            SqlDataAdapter adp = new SqlDataAdapter("select TripLog.TripLogID, Orders.OrderDescription, Orders.OrderArrivalTime, Orders.OrderLocation, Drivers.DriverName from Orders, Drivers, TripLog where Orders.OrderID = TripLog.OrderID and Drivers.DriverID = TripLog.DriverID", Connection.connect);
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

                myTable.Rows.Add(dr);
            }

            try
            {
                string timesheetID = tripGrid.SelectedRows[0].Index.ToString();

                SqlCommand command = new SqlCommand("delete from TripLog where TripLogID = '"+ dt.Rows[tripGrid.SelectedRows[0].Index][0] +"'", Connection.connect);
                command.ExecuteNonQuery();              


                MessageBox.Show("Record deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Select a row first");
            }
        }
    }
}
