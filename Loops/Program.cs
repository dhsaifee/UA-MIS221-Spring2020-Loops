using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

        static void Menu()
        {
            // 1. Create multiplication tables of numbers
            // 2. Check whether a number is even or odd
            // 3. Exit the Menu

            string menuChoice = GetMenuChoice();
        
            while (menuChoice != "3")
            {
                if (menuChoice == "1")
                {
                    Console.WriteLine("\nYou chose multiplication tables.");
                    MultiplicationTables();
                }
                else if (menuChoice == "2")
                {
                    Console.WriteLine("\nYou chose to check whether a number is even or odd.");
                    EvenOrOdd();
                }
                else
                {
                    Console.WriteLine("The menu choice was not valid.");
                }

                menuChoice = GetMenuChoice();
            }
        }


        static void MultiplicationTables()
        {
            Console.WriteLine("Please enter the number upto which you want the multiplication tables: ");
            int number = GetNumber();

            for (int i = 1; i <= number; i++)
            {
                Console.Write("Table for " + i + ":\t");

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j * i + "\t");
                }

                Console.WriteLine();
            }
        }


        static void EvenOrOdd()
        {
            int number = GetNumber();
            int remainder = number % 2;

            switch(remainder)
            {
                case 0:
                    Console.WriteLine(number + " is even.");
                    break;
                default:
                    Console.WriteLine(number + " is odd.");
                    break;
            }
        }

        static int GetNumber()
        {
            Console.Write("Please enter an integer: ");
            int integer = int.Parse(Console.ReadLine());
            return integer;
        }


        static string GetMenuChoice()
        {
            Console.WriteLine("\nPlease enter a choice\n" +
                "1. To create multiplication tables of numbers\n" +
                "2. To check whether a number is even or odd\n" +
                "3. To exit the Menu");
            string userInput = Console.ReadLine();

            //while (!(userInput == "1" || userInput == "2" || userInput == "3"))
            //{
            //    Console.Write("Please enter a valid choice: ");
            //    userInput = Console.ReadLine();
            //}

            return userInput;
        }
    }
}
