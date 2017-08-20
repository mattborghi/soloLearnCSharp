using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
An optional finally block can be used after the catch blocks. The finally block is used to execute a given set of statements, whether an exception is thrown or not. 

The finally block can be used, for example, when you work with files or other resources. These should be closed or released in the finally block, whether an exception is raised or not.
*/

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=0;
            int num1 = 8;
            int num2 = 4;
            try {
                result = num1 / num2;
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Error");
            }
            finally {
                Console.WriteLine(result);
            }
        }
    }
}