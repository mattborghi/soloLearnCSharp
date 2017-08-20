using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Person
        {
            private int age;
            // Constructor of the Person class
            // it's called when a Person object is created
            public Person()
            {
                Console.WriteLine("Hi there");
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
        }
    }
}