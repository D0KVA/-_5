using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    internal class Books
    {
        public Books(string name, string author, string year) {
            Name = name;
            Author = author;
            Year = year;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }

        public Books() { }

    }
}
