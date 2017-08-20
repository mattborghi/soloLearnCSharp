using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        // By value
        static void SqrVal(int x)
        {
            x = x * x;
        }
        // By reference
        static void SqrRef(ref int x)
        {
          x = x * x;
        }
        // By output
        static void ByOutput(out int x)
        {
            x = 2;
        }
        static void Main(string[] args)
        {
            int a = 3;
            // Value
            SqrVal(a);
            
            Console.WriteLine("By Value: {0}",a);
            
            // Reference
            SqrRef(ref a);
            
            Console.WriteLine("By Reference: {0}",a);
            
            // By output: useful when returning multiple outputs
            ByOutput(out a);
            Console.WriteLine("By Output: {0}",a);
        }
    }
}