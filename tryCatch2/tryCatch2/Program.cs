using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for exceptions with the Try Catch Block and the Finally block...

            byte number1 = 0, number2 = 0;

        again: // If an error is encountered, it will return here again...
            Console.WriteLine("Enter the numbers:");

            try
            {
                number1 = Convert.ToByte(Console.ReadLine());
                number2 = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Sum = " + Convert.ToString(number1 + number2));
            }
            catch (FormatException)
            {
                // If you do not enter numeric data, this error block works... For example, press enter instead of entering numbers and try...
                Console.WriteLine("Please enter numerical data...");
                goto again;
            }
            catch (OverflowException)
            {
                // Byte takes values between 0-255, you know... In this case, when a number greater than 255 is entered, this error message is encountered. 
                Console.WriteLine("Error... You are entering very large numbers in the fields...");
                goto again;
            }
            finally
            {
                // In any case, this part will work... It doesn't change whether it's a try or a catch...
                Console.WriteLine("Note: Data between 0-255 can be entered in the byte field. ");
                Console.WriteLine("\n\n\n");
            }

            Console.ReadKey();
        }
    }
}