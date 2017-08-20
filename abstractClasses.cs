using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        // Abstract keyword if used must be declared in class and method.
        // The method in the base class must not contain curly braces, just a semi colon.
        // The specific use for this method must be implemented in each specific derived class.
        abstract class Shape {
            public abstract void Draw();
        }
        class Circle : Shape {
            public override void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                Console.WriteLine("Rect Draw");
            }
        }
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();
        }
    }
}