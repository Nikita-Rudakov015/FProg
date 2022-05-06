using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_OOP_library
{
    internal class Book
    {
        public string name = "name";
        public string author;
        public int countPages;
        public string genreBook;
        public string countryBook;
    }

    public void Print()
    {
        Console.WriteLine($"Name of the book: {name}");
    }
}
