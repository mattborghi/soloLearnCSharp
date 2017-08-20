using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
	    class Cat {
	      // As the variable is declared as static inside the class, all objects created will share the same value.
	      // There is only one copy of the static member.
          public static int count=0;
          public Cat() {
            count++;
            Console.WriteLine("Cat #{0} was created",count);
          }
        }
		static void Main(string[] args)
		{
		    // Create a cat
		    Cat c1 = new Cat();
		    // Create another cat
		    Cat c2 = new Cat();
		    // Creating in main
		    // Static members can be accesed being using the class name without an object.
		    Console.WriteLine("{0} Cats created in total.",Cat.count);
		}
	}
}
