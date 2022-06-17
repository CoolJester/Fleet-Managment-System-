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
    public partial class Cheat2 : Form
    {
        public Cheat2()
        {
            InitializeComponent();            
        }

        string date;

        string[] decriptions = { "Cement Pallets", "Bricks", "Soda Drinks - 500ml", "Iron Bars", "Floor tiles", "Cars", "Clover Milk 1l", "Forklift", "Water Pipes", "Meat", "Smartphones", "Handbags", "Glass Windows", "Mining Drill"};

        string[] locations = { "ST_CPT", "ST_GAU", "ST_KZN", "ST_LIM"};

        Random ren = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 300; i++)
            {
                //id
                string id = "OR";
                for (int x = 0; x < 7; x++)
                {
                    id += ren.Next(9);
                }

                //date
                date = ren.Next(30) + "/11/2021 00:00:00";

                SqlCommand command = new SqlCommand("insert into Orders values('"+ id + "', 'CRFL', '"+ decriptions[ren.Next(decriptions.Length)] +"', '"+date+"', '"+ locations[ren.Next(locations.Length)] +"');", Connection.connect);
                command.ExecuteNonQuery();

                
            }

            MessageBox.Show("Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //getting the orders
            SqlDataAdapter adpt1 = new SqlDataAdapter("select * from Orders", Connection.connect);
            DataTable dt1 = new DataTable();
            adpt1.Fill(dt1);

            MessageBox.Show(dt1.Rows.Count.ToString());

            //getting the driver
            SqlDataAdapter adpt2 = new SqlDataAdapter("select * from Drivers", Connection.connect);
            DataTable dt2 = new DataTable();
            adpt2.Fill(dt2);
        


            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string id = "TL";
                for (int x = 0; x < 6; x++)
                {
                    id += ren.Next(10);
                }

                SqlCommand command = new SqlCommand("insert into TripLog values('"+ id +"', '"+ dt1.Rows[i][0].ToString() +"', '"+ dt2.Rows[ren.Next(dt2.Rows.Count)][0] +"');", Connection.connect);

                command.ExecuteNonQuery();
            }


        }
    }
}
