using System;

class Program
{
    static void Main(string[] args)
    {
        static string DisplayWelcome()
        {
            string message = "Welcome to the Program!";

            return message;
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int square = favoriteNumber * favoriteNumber;

            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
}