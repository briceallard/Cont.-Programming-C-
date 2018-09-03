//////////////////////////////////////////////////////////
// Brice Allard
// Cont. Programming
// Assignment 2
// Project: Create a console application in C# that gets
//  3 numbers from the user and displays the average, sum,
//  largest and smallest numbers.
//////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int[] values = new int[3];

            // Gather user input for calculations
            Console.WriteLine("Assignment 2: Brice Allard");
            Console.WriteLine();
            Console.WriteLine("Insert 3 numbers to average:");
            Console.Write("First: ");
            userInput = Console.ReadLine();
            values[0] = Convert.ToInt32(userInput);
            Console.Write("Second: ");
            userInput = Console.ReadLine();
            values[1] = Convert.ToInt32(userInput);
            Console.Write("Third: ");
            userInput = Console.ReadLine();
            values[2] = Convert.ToInt32(userInput);
            Console.WriteLine();

            // Complete Calculations
            int sum, avg, small, large;
            sum = values[0] + values[1] + values[2];
            avg = sum / 3;
            small = values.Min();
            large = values.Max();

            // Display Calculations
            Console.WriteLine("Calculations complete!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Avg: " + avg);
            Console.WriteLine("Smallest: " + small);
            Console.WriteLine("Largest: " + large);

            // Exit program
            Console.WriteLine("Press any key to exit ...");
            Console.ReadLine();
        }
    }
}
