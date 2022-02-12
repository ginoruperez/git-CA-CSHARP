using System;

namespace MethodAgeName
{
    /*
     * This program demonstrate the use of methods in a class
     * Calculates the year user is born based on age and name inputs
     * Author : Gino Ruperez
     * Date : May 22, 2021
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare local variables for age and name 
            int age;
            string name;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***** Year of birth Calculation *****\n");
            Console.ForegroundColor = ConsoleColor.White;

            name = GetName();
            age = GetAge();

            // Display and calculate user is born            
            CalculateYear(age, name);  
        }

        // Enter the user name, digits and blank are not allowed 
        private static string GetName()
        {
            string name;
            
            Console.WriteLine("Please enter your name :");            
            name = Console.ReadLine();
            while (!IsNameValid(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid character(s) in name!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter your name :");
                name = Console.ReadLine();
            }

            return name; 

        }

        // Enter the age of user
        private static int GetAge()
        {
            int age;
            Console.WriteLine("Please enter your age :");
            while (!(int.TryParse(Console.ReadLine(), out age)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter number only");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return age;
        }



        // Calculate and display the year user was born
        private static void CalculateYear(int age, string name)
        {
            int yearBorn;
            yearBorn = DateTime.Now.Year - age;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{name},  you were born in {yearBorn}");
            Console.ForegroundColor = ConsoleColor.White;


        }

        // Input validation for name
        // all letters including, period,comma and space in name are allowed e.g. Dr. Phil Stewart MD, PhD
        private static bool IsNameValid(string name)
        {
            string trimName;
            trimName = name.Replace(" ","");
            trimName = trimName.Replace(".", "");
            trimName = trimName.Replace(",", "");

            if (string.IsNullOrEmpty(trimName))
            {
                return false;
            }
            foreach (char item in trimName)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
