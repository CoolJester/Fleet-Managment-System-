using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLEET_SYSTEM1._0
{
    public partial class Cheat : Form
    {
        public Cheat()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ID = "T";
            Random ren = new Random();

            for (int i = 0; i < 5; i++)
            {
                ID += ren.Next(9);
            }

            SqlCommand command = new SqlCommand("insert into Timesheet values('"+ ID +"', '"+ txtId.Text +"', '"+ "CRFL" + "', '"+ Convert.ToDateTime(dpDay.Text) + "', '"+ Convert.ToDecimal(ren.Next(10)) +"', '"+ Convert.ToDecimal(ren.Next(3)) +"');", Connection.connect);

            command.ExecuteNonQuery();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cheat2().Show();
        }
    }
}
