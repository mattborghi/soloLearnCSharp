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
            int[ ] arr = {2, 4, 7};
            for(int k=0; k<arr.Length; k++) {
                Console.WriteLine(arr[k]);
            }
            Console.WriteLine("Rank: {0}",arr.Rank);
            Console.WriteLine("Some methods");
            Console.WriteLine("Max: {0}",arr.Max());
            Console.WriteLine("Min: {0}",arr.Min());
            Console.WriteLine("Sum: {0}",arr.Sum());
        }
    }
}