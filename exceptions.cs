using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
An exception is a problem that occurs during program execution. Exceptions cause abnormal termination of the program. 
An exception can occur for many different reasons. Some examples:
- A user has entered invalid data.
- A file that needs to be opened cannot be found.
- A network connection has been lost in the middle of communications.
- Insufficient memory and other issues related to physical resources.

C# provides a flexible mechanism called the try-catch statement to handle exceptions so that a program won't crash when an error occurs.

The code that might generate an exception is placed in the try block. If an exception occurs, the catch blocks is executed without stopping the program.
The type of exception you want to catch appears in parentheses following the keyword catch. 
We use the general Exception type to handle all kinds of exceptions. We can also use the exception object e to access the exception details, such as the original error message (e.Message).

HANDLING MULTIPLE EXCEPTIONS

A single try block can contain multiple catch blocks that handle different exceptions separately. 
Exception handling is particularly useful when dealing with user input.
For example, for a program that requests user input of two numbers and then outputs their quotient, be sure that you handle division by zero, in case your user enters 0 as the second number.

int x, y;
try {
  x = Convert.ToInt32(Console.Read());
  y = Convert.ToInt32(Console.Read());
  Console.WriteLine(x / y);
}
catch (DivideByZeroException e) {
  Console.WriteLine("Cannot divide by 0");
}
catch(Exception e) {
  Console.WriteLine("An error occurred");
}

The above code handles the DivideByZeroException separately. The last catch handles all the other exceptions that might occur. If multiple exceptions are handled, the Exception type must be defined last.
Now, if the user enters 0 for the second number, "Cannot divide by 0" will be displayed. 
If, for example, the user enters non-integer values, "An error occurred" will be displayed.


The following exception types are some of the most commonly used: FileNotFoundException, FormatException, IndexOutOfRangeException, InvalidOperationException, OutOfMemoryException.

*/

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int[] arr = new int[] { 4, 5, 8 };
                Console.Write(arr[8]);
            }
            catch(Exception e) {
                Console.WriteLine("An error occurred");
            }
        }
    }
}