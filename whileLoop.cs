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
            int num = 0;
            Console.WriteLine("Pre-increment");
            while(++num < 6) 
                Console.WriteLine(num);
            
            Console.WriteLine("Post-increment");
            num = 0;
            while(num++ < 6) // Checks the condition before incrementing
                Console.WriteLine(num);
        
            
            int x = 1;
            while (x++ < 5)
            {
                if (x % 2 == 0)
                    x += 2;
            }
            
        }
    }
}