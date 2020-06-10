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
        
        public GenreList GetListOfGenre(string genre)
        {
            List <string> list1  = _dataLayer.ExtractListOfGenre(genre);
            GenreList genreList = new GenreList();
            genreList.BookList = list1;
            return genreList;
        }

        public BookDetails GetBookDetails(int id)
        {
            List <string> list2 = _dataLayer.GetBookDetails(id);
            BookDetails bookDetails = new BookDetails();
            bookDetails.Title = list2[0];
            bookDetails.Author = list2[1];
            bookDetails.Genre = list2[2];

            return bookDetails;
        }

    }
    
}