using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject.Models
{
    public interface IBook
    {
        IEnumerable<Book> findAll();

    }
}