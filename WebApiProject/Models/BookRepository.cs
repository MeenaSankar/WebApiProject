using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject.Models
{
    public class BookRepository:IBook
    {
        private List<Book> listBooks = new List<Book>();
        public BookRepository()
        {
            listBooks.Add(new Models.Book { Id = 1, Name = "JAVA", Category = "Programming", Author = "JOHN" });
            listBooks.Add(new Models.Book { Id = 2, Name = "Algebra", Category = "Maths", Author = "Joseph" });
            listBooks.Add(new Models.Book { Id = 3, Name = "c#", Category = "Programming", Author = "Mary" });
            listBooks.Add(new Models.Book { Id = 4, Name = "Psycology", Category = "Medicine", Author = "Jack" });
            
        }
        public IEnumerable<Book> findAll()
        {
            return listBooks;
        }
    }
}