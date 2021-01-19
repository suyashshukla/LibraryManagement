using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : ControllerBase
    {

        [Route("all")]
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>();
        }

        [Route("{bookId}")]
        public Book GetBook(int bookId)
        {
            return new Book();
        }

        [Route("{bookId}/update")]
        public int PutBook(int bookId, Book book)
        {
            return 0;
        }

        [Route("add")]
        public int PostBook(Book book)
        {
            return 0;
        }

        [Route("{bookId}/delete")]
        public int DeleteBook (int bookId)
        {
            return 0;
        }
    }
}
