using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Person
	{
	    private string name;
	    
	    public string Name
	    {
	        get { return name;  }
	        set { 
	            if ( !String.IsNullOrEmpty(value) )
	                 name = value; 
	                
	            }
	    }
		static void Main(string[] args)
		{
		    Person p1 = new Person();
			Console.WriteLine("Enter your name: ");
			p1.Name = Console.ReadLine();
			Console.WriteLine("Your name is {0}",p1.name);
		}
	}
}
