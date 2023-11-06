using System;

public class BreathingActivity
{
    public void BreathAct()
    {
        Activity activity = new Activity();

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("");

        activity.GetTime();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        activity.ShowAnimation();

        int duration = activity.TimeGetter();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            activity.CountDown("Breath in... ", 4); // Call the CountDown method directly
            Console.WriteLine();
            activity.CountDown("Now breath out... ", 4);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        activity.ShowEndMessage();
    }
}
