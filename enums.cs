using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The enum keyword is used to declare an enumeration: a type that consists of a set of named constants called the enumerator list.
By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
For example, in the following enumeration, Sun is 0, Mon is 1, Tue is 2, and so on:
enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat}; 

You can also assign your own enumerator values:
enum Days {Sun, Mon, Tue=4, Wed, Thu, Fri, Sat}; 

In the example above, the enumeration will start from 0, then Mon is 1, Tue is 4, Wed is 5, and so on. The value of the next item in an Enum is one increment of the previous value.
Note that the values are comma separated.
You can refer to the values in the Enum with the dot syntax.
In order to assign Enum values to int variables, you have to specify the type in parentheses
*/

namespace SoloLearn
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; 
        static void Main(string[] args)
        {
            int x = (int)Days.Tue;
            Console.WriteLine(x);
        }
    }
}