using System;

namespace ConsoleApplicationMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by a space:");

            string input = Console.ReadLine();

            //Change input string into integer array

            int[] numbers = input.Split(',').Select(int.Parse).ToArray();

            //Declare max for further numbers comparing

            int max = int.MinValue;
            
            //Find the max value

            foreach (int number in numbers)
            {
                if (number > max)
                {
                   
                    max = number;
               
            
                }
            }

            Console.WriteLine("The maximum value is: " + max);

            Console.ReadLine();
        }
    }
}
