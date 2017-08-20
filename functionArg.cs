using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static int calc(int from, int to, int step=1) 
        {
          int res=0;
          for(int i=from;i<to;i+=step) {
            res += i;
          }
          return res;
        }
        static void Main(string[] args)
        {
          int res = calc(step:2,to:99,from:5);
          Console.WriteLine(res);
        }
    }
}