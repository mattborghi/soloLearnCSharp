using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The .NET Framework provides a number of generic collection classes, useful for storing and manipulating data.
These classes are contained in the System.Collections.Generic namespace.
List is one of the commonly used collection classes:
*/

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Pink");
            colors.Add("Blue");
            
            foreach (var color in colors) {
                Console.WriteLine(color);
            }
        }
    }
}

/*
We defined a List that stores strings and iterated through it using a foreach loop. 
The List class contains a number of useful methods:
*Add: adds an element to the List.
*Clear: removes all elements from the List.
*Contains: determines whether the specified element is contained in the List.
*Count: returns the number of elements in the List.
*Insert: adds an element at the specified index.
*Reverse: reverses the order of the elements in the List.
So why use Lists instead of arrays?
Because, unlike arrays, the group of objects you work with in a collection can grow and shrink dynamically.
*/


/*
Commonly used generic collection types include:
Dictionary<TKey, TValue> represents a collection of key/value pairs that are organized based on the key.
List<T> represents a list of objects that can be accessed by index. Provides methods to search, sort, and modify lists.
Queue<T> represents a first in, first out (FIFO) collection of objects.
Stack<T> represents a last in, first out (LIFO) collection of objects.
Choose the type of collection class based on the data you need to store and the operations you need.
*/