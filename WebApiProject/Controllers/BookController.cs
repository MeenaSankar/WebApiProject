using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    public class BookController : ApiController
    {
        private BookRepository bk = new BookRepository();
        [HttpGet]
        public IEnumerable<Book>  Get()
        {
            return bk.findAll();
        }
    }
}
