using System;
using System.IO;

class Program
{
    static string textUser = ""; 

    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.Clear();
        while (true)
        {

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            string decision = Console.ReadLine();

            switch (decision)
            {
                case "1":
                    Console.WriteLine ($"{Prompt()}");
                    Console.WriteLine("Enter text:");
                    textUser = Console.ReadLine();
                    
                    Entry entry =  new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    entry._content = textUser;
                    entry._date = dateText;
                    entry._prompt = ($"{Prompt()}");
                    
                    journal.AddingEntry(entry);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.WriteLine("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    List<Entry> loadedEntries = journal.ReadFileInfo(loadFileName);
                    foreach (var loadedEntry in loadedEntries)
                    {
                        loadedEntry.DisplayEntry();
                    }
                    break;
                    
                case "4":
                    Console.WriteLine("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.WriteFileInfo(saveFileName);
                    Console.WriteLine("Text saved to file.");
                    break;

                case "5":
                    Console.WriteLine("Thanks for using this program!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

   
    static string Prompt()
{
    List<string> prompt = new List<string>();
    prompt.Add("What was the most memorable conversation I had today?");
    prompt.Add("Reflect on the highlight of your day.");
    prompt.Add("In what way did I experience a sense of serendipity or luck today?");
    prompt.Add("Describe the most significant feeling or emotion that touched you today.");
    prompt.Add("If you could change one decision or action from today, what would it be?");
    
    Random rand = new Random();
    int index = rand.Next(prompt.Count); // Get a random index within the range of the list

    return prompt[index]; // Return the randomly selected prompt
}
}