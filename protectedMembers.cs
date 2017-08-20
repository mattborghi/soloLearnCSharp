using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        // We have public, private and protected members.
        // protected ones can be accesed in the same class or in one inherited.
        class Person {
            protected int Age {get; set;}
            protected string Name {get; set;}
        }
        class Student : Person {
            public Student(string nm) {
                Name = nm;
            }
            public void Speak() {
                Console.Write("Name: "+Name);
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("David");
            s.Speak();
            // s.Name = "Carl"; --> we will get an error for this because Name is a protected property of Person's class.
            // it can be accesed from an inherited class only.
        }
    }
}