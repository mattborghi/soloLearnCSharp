using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Generics allow the reuse of code across different types.
For example, let's declare a method that swaps the values of its two parameters:

static void Swap(ref int a, ref int b) {
  int temp = a;
  a = b;
  b = temp;
}

Our Swap method will work only for integer parameters. If we want to use it for other types, for example, doubles or strings, we have to overload it for all the types we want to use it with. Besides a lot of code repetition, it becomes harder to manage the code because changes in one method mean changes to all of the overloaded methods.
Generics provide a flexible mechanism to define a generic type.

static void Swap<T>(ref T a, ref T b) {
  T temp = a;
  a = b;
  b = temp;
}

In the code above, T is the name of our generic type. We can name it anything we want, but T is a commonly used name. Our Swap method now takes two parameters of type T. We also use the T type for our temp variable that is used to swap the values.
Note the brackets in the syntax <T>, which are used to define a generic type.

When calling a generic method, we need to specify the type it will work with by using brackets. So, when Swap<int> is called, the T type is replaced by int. For Swap<string>, T is replaced by string. 
If you omit specifying the type when calling a generic method, the compiler will use the type based on the arguments passed to the method.
Multiple generic parameters can be used with a single method. 
For example: Func<T, U> takes two different generic types.
*/

namespace SoloLearn
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);
            
            string x = "Hello";
            string y = "World";
            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);
        }
    }
}