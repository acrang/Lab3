using System;
using System.Dynamic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter your name.");
            string name = Console.ReadLine();

            bool userContinue = true;
            while (userContinue)
            {
                bool isValid = false;

                int number = 0;

                Console.WriteLine($"{name}, please enter a number between 1 and 100.");


                while (isValid == false)
                {
                    string userInput = Console.ReadLine();

                    isValid = int.TryParse(userInput, out number);

                    if ((number >= 1) && (number <= 100))
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        Console.WriteLine($"Invalid entry, {name}. Please enter a number between 1 and 100.");
                    }
                }

                if (number % 2 != 0)
                {
                    if ((number > 60))
                    {
                        Console.WriteLine($"{name}, the number is odd and greater than 60.");
                    }
                    else
                    {
                        Console.WriteLine($"{name}, the number is odd.");
                    }
                }
                if (number % 2 == 0)
                {
                    if ((number >= 2) && (number <= 25))
                    {
                        Console.WriteLine($"{name}, the number is even and less than 25.");
                    }
                    else if ((number >= 26) && (number <= 60))
                    {
                        Console.WriteLine($"{name}, the number is even and between 26 and 60.");
                    }
                    else if (number > 60)
                    {
                        Console.WriteLine($"{name}, the number is even and greater than 60.");
                    }
                }

                Console.WriteLine($"Would you like to continue, {name}? y/n");
                string continueInput = Console.ReadLine();
                if (continueInput == "n")
                {
                    Console.WriteLine($"Thank you, {name}. Goodbye.");
                    break;
                }
            }
        }
    }
}
