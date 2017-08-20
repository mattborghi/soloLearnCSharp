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
            string myName;
            
            Console.WriteLine("What is your name?");
            
            myName = Console.ReadLine();
            
            Console.WriteLine("Hello {0}!",myName);
        
        }
        
    }
}