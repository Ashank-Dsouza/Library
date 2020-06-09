using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;

namespace ServiceLayer
{
    public class Service : IService
    {
        
        public List<string> GetListOfGenre(string genre)
        {
            DataLayer dl = new DataLayer();
            return dl.ExtractListOfGenre(genre);
        }

        public List<string> GetBookDetails(int id)
        {
            DataLayer dl = new DataLayer();
            return dl.GetBookDetails(id);
        }

    }

    
}