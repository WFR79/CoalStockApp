using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBussiness
{
    public class SqlConn
    {
        public bool ConnectionTest()
        {
            SqlConnection sqlConnection = new SqlConnection("Home");
            //SqlConnection.
            return true;
        }
    }
}
