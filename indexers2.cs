using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            char x = str[4];
            Console.WriteLine(str);
            Console.WriteLine("By indexing");
            Console.WriteLine("Fifth element: {0}",x);
        }
    }
}