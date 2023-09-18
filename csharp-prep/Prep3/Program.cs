using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        string guessNumberString = "0";
        int guessNumber = 0;

        // Console.WriteLine(number);
        
        while (guessNumber != number)
        {
            Console.Write("Guess the number: ");
            guessNumberString = Console.ReadLine();
            guessNumber = int.Parse(guessNumberString);

            if (guessNumber > number)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else if (guessNumber < number)
            {
                Console.WriteLine("Your guess is too low!");
            }
            else if (guessNumber == number)
            {
                Console.WriteLine("You guess right");
            }
        }
        

    }
}