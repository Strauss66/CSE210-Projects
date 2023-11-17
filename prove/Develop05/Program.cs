using System;

class Program
{
    static void Main(string[] args)
    {
        Goals goals = new Goals();
        string answer = "";
        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Events");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select choice from the menu:");
            answer = Console.ReadLine(); 

            switch (answer)
            {
                case "1":
                    goals.Planned();
                    break;
                case "2":
                    //
                    break;
                case "3":
                    //
                    break;
                case "4":
                    //
                    break;
                case "5":
                    //
                    break;
                case "6":
                    Console.WriteLine("Have an amazing day!");
                    //exit the program
                    break;
                default:
                    Console.WriteLine("Pick an available option.");
                    break;
            }
        }
    }
}