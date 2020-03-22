using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lab3PRN.Model
{
   
    class DBContext

    {
        SqlConnection connection;
        public SqlConnection GetConnection()
        {
           
            String connect_text = ConfigurationManager.ConnectionStrings["Lab3PRN.Properties.Settings.Setting"].ConnectionString;
            connection = new SqlConnection(connect_text);
            return connection;
        }
    }
}
