using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	// What is the output of this code?
    class Temp 
    {
      public int num = 2;
      // Cpnstructor
      public Temp() 
      { 
        num++;
        Console.WriteLine("Constructor, num: {0}",this.num);  
      }
      // Destructor
      ~Temp() 
      { 
        num++; 
        Console.WriteLine("Destructor, num: {0}",this.num);  
      }
    }
    
    class Program
    {
        static void Main(string[] args) 
        {
          Temp t = new Temp();
          Console.WriteLine(t.num);
        }    
    }
    
}
