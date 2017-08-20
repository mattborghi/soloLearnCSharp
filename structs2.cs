using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Structs can contain methods, properties, indexers, and so on. Structs cannot contain default constructors (a constructor without parameters), but they can have constructors that take parameters. In that case the new keyword is used to instantiate a struct object, similar to class objects.

In general, classes are used to model more complex behavior, or data, that is intended to be modified after a class object is created. Structs are best suited for small data structures that contain primarily data that is not intended to be modified after the struct is created. Consider defining a struct instead of a class if you are trying to represent a simple set of data.

All standard C# types (int, double, bool, char, etc.) are actually structs.
*/
namespace SoloLearn
{
    class Program
    {
        struct Point {
            public int x;
            public int y;
            public Point(int x, int y) {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            Point p = new Point(10, 15);
            Console.WriteLine(p.x);
        }
    }
}