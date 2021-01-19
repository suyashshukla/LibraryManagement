using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Visitor
    {

        public string Name { get; set; }

        public int BookId { get; set; }

        public DateTime LentOn { get; set; }

        public DateTime ReturnedOn { get; set; }

    }
}
