using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static int Factorial(int num)
        {
            if (num == 1)
                return 1;
            return num*Factorial(num -1);
        }
        static void Main(string[] args)
        {
            //Factorial by recursion
            Console.WriteLine(Factorial(6));
        }
    }
}