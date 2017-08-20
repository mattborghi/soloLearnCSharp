using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Using generic methods with different type-input parameters
*/

namespace SoloLearn
{
    class Program
    {
        static void Print<T,U>(ref T a, ref U b) {
            Console.WriteLine(a+" "+b);
        }
        static void Main(string[] args)
        {
            int a = 4;
            string b = "casa";
            
            Print(ref a, ref b);
            
        }
    }
}