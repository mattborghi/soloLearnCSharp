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
            
            Console.WriteLine("Solve the exercise: ");
            Console.WriteLine("2 + ... = 5");
            int number = Convert.ToInt32( Console.ReadLine() );
            if ( number == 3){
                Console.WriteLine("Correcto! 2 + {0} = 5",number);
            }else{
                Console.WriteLine("Incorrecto! 2 + {0} != 5",number);
            }
        }
    }
}