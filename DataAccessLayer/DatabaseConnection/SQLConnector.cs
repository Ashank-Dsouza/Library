using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
    public class SQLConnector
    {
        private static string connectionString = "Data Source=RENTLAPT068;Initial Catalog=Library;Persist Security Info=True;User ID=sa";
        private static SqlConnection connection;

        static SQLConnector GetSQLConnector()
        {
            return new SQLConnector();
        }
        static void Connect()
        {
            
            connection = new SqlConnection(connectionString);

            connection.Open();

        }

        static void Disconnect()
        {
            connection.Close();
        }

    }
}