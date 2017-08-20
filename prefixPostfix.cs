using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            
            Console.WriteLine("Prefix and postfix");
            
            //Prefix 
            x = 1;
            y = ++x;
            
            Console.WriteLine("Prefix: x = 1; y = ++x; x = {0}, y = {1}",x,y);
            
            //Postfix
            x = 1;
            y = x++;
            
            Console.WriteLine("Postfix: x = 1; y = x++; x = {0}, y = {1}",x,y);
            
            Console.WriteLine("++x: {0}",++x);
            Console.WriteLine("x++: {0}",x++);
           
        }
        
    }
}