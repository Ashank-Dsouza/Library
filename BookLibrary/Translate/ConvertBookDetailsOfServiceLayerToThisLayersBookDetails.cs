using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary
{
    public class Translate
    {
        public static BookDetails ServiceLayerToBookLibraryLayerForBookDetails(ServiceLayer.BookDetails slBookDetails)
        {
            BookDetails bookDetails = new BookDetails();
            bookDetails.Title = slBookDetails.Title;
            bookDetails.Author = slBookDetails.Author;
            bookDetails.Genre = slBookDetails.Genre;

            return bookDetails;
        }

    }
}