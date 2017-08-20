using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        // the sealed modifier prohibits another class to be inherited from it.
        sealed class Animal {
            //some code
        }
        class Dog : Animal { } //Error
        
        static void Main(string[] args)
        {
            
        }
    }
}