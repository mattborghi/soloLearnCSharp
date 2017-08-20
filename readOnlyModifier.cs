using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Person
    {
        // The difference between readonly and properties without set
        // Readonly can be changed only by the class constructor. ig, in this case Person().
        // Whereas the const cannot be modified at all after initialization.
        public readonly int age=54;
        public int age1 { get { return 54; } }
        public Person()
        {
            this.age = 10; //OK
             //this.age1 = 10; //Error
        }
    }
	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person();
			Console.WriteLine("Age: {0}",p1.age);
		}
	}
}
