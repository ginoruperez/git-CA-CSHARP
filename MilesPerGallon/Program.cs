using System;

namespace MilesPerGallon
{
    /*
     * This program calculates Miles per Gallon based on user input
     * Author : Gino Ruperez
     * Date : May 22, 2021
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare local variables 
            double miles, gallons;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***** Calculate Miles per Gallon *****\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Please Enter number of miles driven :");
          
            // Enter number with or without decimal is accepted
            while ( ! (double.TryParse(Console.ReadLine(), out miles)) )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter number only");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("Please Enter gallons of petrol used :");
        
            // Enter number with or without decimal is accepted
            while(!(double.TryParse(Console.ReadLine(), out gallons )))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter number only");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( $"Miles Per Gallon is equal to {miles/gallons}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
