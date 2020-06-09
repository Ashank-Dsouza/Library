using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ServiceLayer;

namespace BookLibrary
{
    public class DetailsController : ApiController
    {
        // GET: Details
        public List<string> Get(int id)
        {
            Service serviceLayer = new Service();
            return serviceLayer.GetBookDetails(id);
        }
    }
}