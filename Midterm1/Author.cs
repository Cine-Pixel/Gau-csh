using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1 {
    public class Author {
        private string FirstName;
        private string LastName;

        public Author(string firstname, string lastname) {
            FirstName = firstname;
            LastName = lastname;
        }

        public string Info() {
            return $"Author name: {FirstName}\nAuthor lastname: {LastName}\n";
        }
    }
}
