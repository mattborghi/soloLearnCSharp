using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main()
        {
            Console.WriteLine("You are in Main Method.");
            Console.WriteLine("---");
            Enter(5);
            Console.WriteLine("---");
            Enter(5.2);
        }
        
        static void Enter(int n)
        {
            Console.WriteLine("You are in Enter Method with INT parameter");
            Console.WriteLine(n);
        }
        
        static void Enter(double n)
        {
            Console.WriteLine("You are in Enter Method with DOUBLE parameter");
            Console.WriteLine(n);
        }
	}
}
