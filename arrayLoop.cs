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
            int[ ] a = new int[10];
            for (int k = 0; k < 10; k++) {
                a[k] = k*2;
            }
            for (int k = 0; k < 10; k++) {
                Console.WriteLine(a[k]);
            }
            
            /* 
            This can be improved using the foreach loop
            The foreach loop iterates through the array a and assigns the value of the current element 
            to the variable k at each iteration of the loop. So, at the first iteration, 
            k=a[0], at the second, k=a[1], etc. 
            */
            
            Console.WriteLine("-------------------------");
            foreach (int k in a)
            {
                // k has to be the same type as a
                Console.WriteLine(k);
            }
            
        }
    }
}