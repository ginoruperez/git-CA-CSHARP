using System;

namespace ArrayOfGrades
{
    /*
     * This program display elements from Grades array
     * Author : Gino Ruperez
     * Date : May 22, 2021
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare array as type double 
            double[] grades = new double[] { 34.7, 56.9, 75, 52, 92.2 };

            //Print to screen the size of grades array
            Console.WriteLine($"Size of grades Array is {grades.Length}\n");

            //Prnt to screen the grade 56.9 from 2nd element
            Console.WriteLine($"Grade : {grades[1]}\n");

            //Print to screen all grades from the grades array
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***** List of grades *****");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Grade : {grades[i]}");
            }

        }
    }
}
