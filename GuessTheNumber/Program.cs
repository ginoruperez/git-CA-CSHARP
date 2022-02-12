using System;

namespace GuessTheNumber
{
    /*
     * This is a simple Guessing game program  
     * Author : Gino Ruperez     
     * Date : May 22, 2021
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare local variables
            int secretNumber, guessNumber;
            bool isNumberGuessed = false;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***** Guess The Number Game *****\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Player 1 : Please Enter a secret number from 0-20");

            // Enter the secret number between 0 and 20
            while (!(int.TryParse(Console.ReadLine(), out secretNumber)) ||  !(secretNumber>=0 && secretNumber<=20 ) )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter number between 0 and 20 only");
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.Clear();


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Player 2 : Please enter your guess number");
                
                // Enter the guess number
                while( !(int.TryParse(Console.ReadLine(), out guessNumber)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter number only");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (guessNumber == secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations you guessed the secret number!");
                    Console.ForegroundColor = ConsoleColor.White;
                    isNumberGuessed = true;
                    break;
                }
                else if (guessNumber < secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Your guess is too low, you have {3-(i+1)} attempt left");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Your guess is too high, you have {3-(i+1)} attempt left");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            if (!isNumberGuessed)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hard Luck, the number was {secretNumber}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
