using System;

class Program
{
    static void Main(string[] args)
    {
        Background bk = new Background();
        Goals g = new Goals();
        string answer = "";

        while (answer != "6")
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Events");
            Console.WriteLine("   6. Quit");
            Console.WriteLine("Select choice from the menu:");
            answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    bk.Planned();
                    break;
                case "2":
                    g.DisplayListItems();
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
                    break;
                default:
                    Console.WriteLine("Pick an available option.");
                    break;
            }
        }
    }
}