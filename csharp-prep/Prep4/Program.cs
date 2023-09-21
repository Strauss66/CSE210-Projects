using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        var numbers = new List<int>();
        int number = 1;
        int sum = 0;
        int max = -9999;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            var userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        }
        if (numbers.Count > 0)
        {   
            foreach (var num in numbers)
            {
                sum += num;
                if (max < num)
                {
                    max = num;
                }
            }
        }
        var avg = sum / numbers.Count;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Maximum: {max}");
    }
}