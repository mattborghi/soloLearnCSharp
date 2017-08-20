using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class SomeClass {
            public static int X { get; set; }
            public static int Y { get; set; }
            
            // Constructor
            static SomeClass() {
                X = 10;
                Y = 20;
            }
        }
        static void Main(string[] args)
        {
            // Constructors can be declared static to initialize static members of the class.
            // The static constructor is automatically called once when we access a static member of the class.
            Console.WriteLine(SomeClass.X);
        }
    }
}