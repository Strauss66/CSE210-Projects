using System;
using System.Threading;

public class Activity
{
    private string _name;
    private int _duration;

    public void ShowStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine("");
    }

    public void ShowEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        ShowAnimation();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity.");
        ShowAnimation();
    }

    public void GetTime()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        var Userduration = Console.ReadLine();
        _duration = int.Parse(Userduration);
    }

    public void ShowAnimation()
    {
        for (int i = 0; i < 3; i++) // Adjusted the loop count for a visible animation
        {
            Console.Write("/");
            Thread.Sleep(550); // Adjusted the sleep time for a better display
            Console.Write("\b \b-");
            Thread.Sleep(550);
            Console.Write("\b \b|");
            Thread.Sleep(550);
            Console.Write("\b \b");
        }
    }

    public void CountDown(string message, int repeatTimes)
    {
        Console.Write(message);
        for (int i = repeatTimes; i >= 1; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            if (i > 0)
            {
                Console.Write("\b \b"); // Clears the last character
            }
        }
    }

    public void NameSetter(string name)
    {
        _name = name;
    }

    public int TimeGetter()
    {
        int time = _duration;
        return time;
    }
}