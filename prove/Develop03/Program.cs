using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        Reference reference = new Reference();
        Scripture scrip = new Scripture();
        Word word = new Word("");
        scrip.Cutter();

        int hiddenWordCount = 0;

        while (hiddenWordCount < scrip.GetWordCount())
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            answer = Console.ReadLine();

            if (answer == "")
            {
                Console.Clear();
                reference.Display();
                hiddenWordCount += scrip.Display();
            }
            else if (answer == "quit")
            {
                Console.WriteLine("Thanks for playing");
                break;
            }
        }
    }
}