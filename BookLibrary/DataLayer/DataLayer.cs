using BookLibrary.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookLibrary
{
    public class DataLayer
    {
        public SqlConnection connection;

        string connectionString = "Data Source=RENTLAPT068;Initial Catalog=Library;Persist Security Info=True;User ID=sa; Password=test123!@#";

        public SqlConnection GetConnection()
        {

            connection = new SqlConnection(connectionString);

            connection.Open();
            return connection;
        }

        public List<string> ExtractListOfGenre(string genre)
        {
            List<string> list5 = new List<string>(5);
            
            SqlCommand sqlCommand = new SqlCommand("SELECT Title FROM BookList WHERE Genre =@Genre", GetConnection());
            sqlCommand.Parameters.AddWithValue("@Genre", genre);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                list5.Add(reader[0].ToString());
            }
            return list5;
        }

        public List<string> GetBookDetails(int id)
        {
            List<string> list5 = new List<string>(5);

            SqlCommand sqlCommand = new SqlCommand("SELECT *FROM BookList WHERE BookId =@BookId", GetConnection());
            sqlCommand.Parameters.AddWithValue("@BookId", id.ToString());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            list5.Add(reader["Title"].ToString());
            list5.Add(reader["Author"].ToString());
            list5.Add(reader["Genre"].ToString());


            return list5;
        }
            
    }
}