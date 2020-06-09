using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BookLibrary
{
    public class DetailsController : ApiController
    {
        // GET: Details
        public List<string> Get(int id)
        {
            ServiceLayer serviceLayer = new ServiceLayer();
            return serviceLayer.GetBookDetails(id);
        }
    }
}