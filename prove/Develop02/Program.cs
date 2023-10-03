using System;
using System.IO;

class Program
{
    static string textUser = ""; // Initialize textUser as a global variable

    static void Main(string[] args)
    {
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
                    Console.WriteLine("Enter text:");
                    textUser = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine($"Text entered: {textUser}");
                    break;
                case "3":
                    Console.WriteLine("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    string loadedText = ReadFileInfo(loadFileName);
                    Console.WriteLine("Loaded text: " + loadedText);
                    break;
                case "4":
                    Console.WriteLine("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    WriteFileInfo(saveFileName);
                    Console.WriteLine("Text saved to file.");
                    break;
                case "5":
                    Console.WriteLine("Thanks for using this program!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static string ReadFileInfo(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        string text = string.Join(Environment.NewLine, lines);
        return text;
    }

    static void WriteFileInfo(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Write the textUser content to the file
            outputFile.WriteLine(textUser);
        }
    }
}
