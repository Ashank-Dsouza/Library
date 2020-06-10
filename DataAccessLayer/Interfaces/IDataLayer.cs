using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        SqlConnection GetConnection();

        List<string> ExtractListOfGenre(string genre);

        List<string> GetBookDetails(int id);
    }
}
