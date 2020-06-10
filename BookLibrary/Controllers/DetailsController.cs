using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class DetailsController : ApiController
    {
        public IService _service =  new Service(); 
        // GET: Details
        public void Get()
        {
            return;
        }

        // GET: /api/details/1
        public List<string> Get(int id)
        {
            return _service.GetBookDetails(id);
        }
    }
}