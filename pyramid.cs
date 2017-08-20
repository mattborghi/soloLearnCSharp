using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
  class Program
  {
    static void DrawPyramid(int n)
    {
        // Loop over rows
      for (int i=1; i<=n; i++)
      {
          // Space betfore the first dot
        for (int j=i; j<=n; j++)
        {
          Console.Write("  ");
        }
        for (int k=1; k<=2*i-1; k++)
        {
          Console.Write("*"+" ");
        }
        // Go to the next line
        Console.WriteLine();
      }
    }
    static void Main(string[] args)
    {
        // The input parameter is the number of rows
      DrawPyramid(5);
    }
  }
}