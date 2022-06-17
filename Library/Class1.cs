using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Connection
    {

        public static SqlConnection connect { get; set; }

        public void establishConnection()
        {
            connect.Open();
        }

    }
}
