using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        BreathingActivity breath = new BreathingActivity();
        ReflectingActivity reflect = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        string answer = "";

        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            answer = Console.ReadLine(); 

            switch (answer)
            {
                case "1":
                    activity.NameSetter("breathing");
                    activity.ShowStartMessage();
                    breath.BreathAct();
                    break;
                case "2":
                    activity.NameSetter("reflecting");
                    activity.ShowStartMessage();
                    reflect.ReflectActivity();
                    break;
                case "3":
                    activity.NameSetter("listing");
                    activity.ShowStartMessage();
                    listing.ListActivity();
                    break;
                case "4":
                    Console.WriteLine("Have an amazing day!");
                    break;
                default:
                    Console.WriteLine("Pick an available option.");
                    break;
            }
        }
    }
}