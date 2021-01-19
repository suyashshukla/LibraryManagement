using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    [Route("api/visitor")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        [Route("all")]
        public IEnumerable<Visitor> GetAllVisitors()
        {
            return new List<Visitor>();
        }

        [Route("{visitorId}")]
        public Book GetVisitor(int visitorId)
        {
            return new Book();
        }

        [Route("{visitorId}/update")]
        public int PutVisitor(Visitor visitor)
        {
            return 0;
        }

        [Route("add")]
        public int PostVisitor(Visitor visitor)
        {
            return 0;
        }

        [Route("{visitorId}/delete")]
        public int DeleteBook(int visitorId)
        {
            return 0;
        }
    }
}
