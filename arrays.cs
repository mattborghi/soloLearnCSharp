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
            
            // Declaring an array
            string[] casa = new string[3];
                // Assigning a value
            casa[0] = "Dormitorio";
            Console.WriteLine(casa[0]);
            // We can assign the values in one line
            double[] numbers = new double[3] {3.14159,2.7172,123.45};
            Console.WriteLine(numbers[0]);
            // We can ommit the number of elements
            char[] ascii = new char[] {'a','b','c'};
            Console.WriteLine(ascii);
            // Finally we can ommit the 'new type' declaration in the RHS
            int[ ] b = {11, 45, 62, 70, 88};

            Console.WriteLine("{0},{1}",b[2],b[3]);
        }
    }
}