using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade in percentage? ");

        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.Write("I'm sorry but you didn't passed the class, maybe next time? ");
        }

        Console.Write($"You got a {letter}");
    }
}