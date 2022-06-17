using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLEET_SYSTEM1._0
{
    public class Connection
    {

        public static SqlConnection connect { get; set; }
        public static string FirstName { get => firstName; set => firstName = value; }
        public static string Position { get => position; set => position = value; }

        private static string firstName = "";
        private static string position = "";
        public void establishConnection()
        {
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ntsako\Downloads\WILDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            connect.Open();
        }

    }
}
