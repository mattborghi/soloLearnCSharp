using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        // Interfaces
        // why use interfaces rather than abstract classes? 
        // A class can inherit from just one base class, but it can implement multiple interfaces!
        // Therefore, by using interfaces you can include behavior from multiple sources in a class.
        // To implement multiple interfaces, use a comma separated list of interfaces when creating the class: class A: IShape, IAnimal, etc.
        public interface IShape {
            // you cant have variable declarations in an interface.
            void Draw();
        } // methods implemented from interfaced class dont neeed the override keyword.
        // The interface name is used to preimplement an I- in the name.
        class Circle : IShape {
            public void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Draw();
        }
    }
}