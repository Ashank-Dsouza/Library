using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookLibrary.Controllers
{
    public class GetAllBooksByGenreController : ApiController
    {
        public IService _service;
        // GET api/values
        public string Get()
        {
            return GetBookDetails();
        }

        // GET api/GetAllBooksByGenre/5
        public List<string> Get(int id)
        {
            _service = new Service();
            string genre = "Fantasy";
            return _service.GetListOfGenre(genre);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public string GetBookDetails()
        {
            return  "Author Jk Rowling";
        }

        public string[] GetBooksOfGenreNumber()
        {
            return new string[]
            {
               "Harry Potter",
               "Lord Of The Rings"
            };
        }
    }
}
