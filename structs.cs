using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        // structs look similar to classes but they dont support inheritance or interfaces.
        struct Book {
            public string title;  
            public double price;
            public string author;
        }
        static void Main(string[] args)
        {
            Book b;
            b.title = "Test";
            b.price = 5.99;
            b.author = "David";
            
            Console.WriteLine(b.title);
        }
    }
}