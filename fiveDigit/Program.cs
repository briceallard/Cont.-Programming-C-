/* Brice Allard
 * CMPS 4143: Contemporary Programming Languages
 * September 5th, 2018
 * Dr. Stringfellow
 * Description: Console Application that reads numerical input from
 *  user and displays it back seperated by individual digits. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string numInput;

            Console.WriteLine("Brice Allard: Assignment 3");
            Console.WriteLine();
            Console.Write("Enter a 1-5 digit number: ");
            numInput = Console.ReadLine();

            int length = numInput.Length;
            int[] arrayOfInts = new int[length];

            if (length > 5)
            {
                Console.WriteLine("Too many digits entered.");
                Console.Read();
                System.Environment.Exit(1);
            }
            else if (length >= 1 && length <= 5)
            {
                for (int i = 0; i < length; i++)
                {
                    arrayOfInts[i] = (int)Char.GetNumericValue(numInput, i);
                }

                for (int i = 0; i < length; i++)
                {
                    Console.Write(arrayOfInts[i] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.Read();
        }
    }
}
