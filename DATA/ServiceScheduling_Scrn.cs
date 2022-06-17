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

//push 
namespace FLEET_SYSTEM1._0
{
    public partial class ServiceScheduling_Scrn : UserControl
    {

        /// <summary>
        /// Feel free to clean up the code as much as you like
        /// because the Library was missing the connection string was slightly altered, so re-alter if you want to
        /// </summary>

        //init. public Connection String

        SqlConnection con = new SqlConnection(Connection.connect.ConnectionString);

        public ServiceScheduling_Scrn()
        {
            InitializeComponent();
        }

        private void DisplayCallServiceData()
        {
            //displaying the VehicleServicingSchedule on the gridCallService DataGrid

            try
            {
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT VehicleScheduleID, VehicleID, ServiceDescription, ScheduleDate FROM VehicleServicingSchedule ORDER BY ScheduleDate DESC", con);
                DataTable dtbl = new DataTable("VehicleServicingSchedule");
                ada.Fill(dtbl);
                gridCallService.DataSource = dtbl.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish connection to the server\n" +
                    "", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DisplayCompletedServiceData()
        {
            //displaying the VehicleServicingSchedule on the gridCallService DataGrid
            //getting the day today, intention is to use for quering the COMPLETED SERVICES (gridCompletedService) 
            DateTime today = DateTime.Today;    //UNUSED    
            try
            {
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT VehicleScheduleID, VehicleID, ServiceDescription, ScheduleDate FROM VehicleServicingSchedule WHERE datediff(dd,ScheduleDate,GETDATE()) < 5 ", con);
                DataTable dtbl = new DataTable("VehicleServicingSchedule");
                ada.Fill(dtbl);
                gridCallService.DataSource = dtbl.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish connection to the server\n" +
                    "", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void ServiceScheduling_Scrn_Load(object sender, EventArgs e)
        {
            //displaying the VehicleServicingSchedule on the gridCallService DataGrid
            DisplayCallServiceData();

        }

        //i have no idea why all these events were made, just minimize
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void txtServices4_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtServices3_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtServices2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void dateAppointmentDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtServices1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void txtVehicleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        //in the VehicleServiceScheduling table, the ScheduleLoaction field is not needed
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection(Connection.connect.ConnectionString);
            //int loc declared and initialized to 1 as a constant to insert into the database, since NULLS are not allowed :(
            int loc = 1;

            //gets the current day and time 
            DateTime now = DateTime.Now;

            //if the set appointment date is BEFORE the CURRENT date, the appointment cannot be scheduled
            DateTime appointment = DateTime.Parse(Convert.ToDateTime(dateAppointmentDate.Text).ToShortDateString());
            if (appointment <= now)
            {
                MessageBox.Show("appointment date cannot be before the current date");
            }

            try
            {
                SqlCon.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO VehicleServicingSchedule (VehicleScheduleID, VehicleID, ServiceDescription, ScheduleDate, ScheduleLocation) VALUES(@VehicleScheduleID, @VehicleID, @ServiceDescription, @ScheduleDate, @ScheduleLocation)", SqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@VehicleScheduleID", txtProcedureCode.Text);
                cmd.Parameters.AddWithValue("@VehicleID", txtVehicleNumber.Text);
                cmd.Parameters.AddWithValue("@ServiceDescription", (txtServices1.Text + ", " + txtServices2.Text + ", " + txtServices3.Text + ", " + txtServices4.Text));
                cmd.Parameters.AddWithValue("@ScheduleDate", appointment);
                cmd.Parameters.AddWithValue("@ScheduleLocation", loc.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Service recorded");

                DisplayCallServiceData();

                txtProcedureCode.Clear();
                txtVehicleNumber.Clear();
                txtServices1.Clear();
                txtServices2.Clear();
                txtServices3.Clear();
                txtServices4.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error inserting data");
            }
            finally
            {
                SqlCon.Close();
            }
        }

        private void txtProcedureCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //after scheduling a servicing, the datagrid does not automatically refresh, hence this button which basically just runs the SELECT query
            //but the application seems to not refresh the datagrid after hitting this button with the new records added to the VehicleServiceScheduling Table
            DisplayCallServiceData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM VehicleServicingSchedule WHERE VehicleScheduleID = '" + txtProcedureCode2 + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error occurred while attempting to remove " + txtProcedureCode2.Text);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
