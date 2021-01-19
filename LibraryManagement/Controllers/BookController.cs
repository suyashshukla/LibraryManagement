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

        [Route(""]
        public IEnumerable<Book> GetBooks()
        {

        }

        [Route(""]
        public Book GetBook(int bookId)
        {

        }

        [Route(""]
        public int UpdateBook(Book book)
        {

        }

        public int DeleteBook (int bookId)

    }
}
