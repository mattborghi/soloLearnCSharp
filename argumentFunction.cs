using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static int suma(int x, int y=2)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            // Call function suma
            Console.WriteLine(suma(2));
            // Call function sumas
            Console.WriteLine(suma(1,2));
        }
    }
}