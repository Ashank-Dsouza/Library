using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data.SqlClient;

namespace ServiceLayer
{
    public class Service : IService
    {
        public IDataLayer _dataLayer = new DataLayer();
        
        public List<string> GetListOfGenre(string genre)
        {
            return _dataLayer.ExtractListOfGenre(genre);
        }

        public List<string> GetBookDetails(int id)
        {
            return _dataLayer.GetBookDetails(id);
        }

    }

    
}