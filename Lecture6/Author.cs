using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture6 {
    public class Author {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Book> Books { get; set; } 
    }
}
