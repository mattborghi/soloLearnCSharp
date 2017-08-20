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
            // A jagged array allowes us to define arrays of different lengths.
            int[ ][ ] jaggedArr = new int[ ][ ] 
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}
            };
            int x = jaggedArr[2][1];
            Console.WriteLine(x);
            
            int[][,] newArray = new int[8][,];
            Console.WriteLine(newArray);
        }
    }
}