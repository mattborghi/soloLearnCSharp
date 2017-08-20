using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        // Polymorphism
        // The polymorphic approach allows us to treat each object the same way. 
        // As all objects are of type Shape, it is easier to maintain and work with them. 
        
        // So, poly needs to things: virtual + override = polymorphism
        // virtual keyword is inserted in the base class method.
        // and override is in the derived class method.
        class Shape {
            public virtual void Draw() {
                Console.Write("Base Draw");
            }
        }
        class Circle : Shape {
            public override void Draw() {
                // draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                // draw a rectangle...
                Console.WriteLine("Rect Draw");
            }
        }
        static void Main(string[] args)
        {
            // If i wouldn't have used polymorphism i should have write instead
            // Circle c = new Circle();
            // and the same for every other shape.
            // which is a mess. In this way using poly we can treat each shape in the same way.
            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();
        }
    }
}
