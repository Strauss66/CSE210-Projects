using System;

public class ReflectingActivity
{
    Activity activity = new Activity();
    public void ReflectActivity()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you fecognize the power you have and how you can use it in other aspects of your life. ");
        Console.WriteLine("");

        activity.GetTime();
        Console.Clear();
        Console.WriteLine("Get ready... ");
        activity.ShowAnimation();
        Console.Clear();

        RandomPrompt();
        var answer = Console.ReadLine();
        if (answer == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this expirience.");
            activity.CountDown("You may begin in: ", 6);
            Console.Clear();

            int duration = activity.TimeGetter();
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);
            DateTime currentTime = DateTime.Now;
            while (currentTime < futureTime)
            {
                RandomQuestion();
                activity.ShowAnimation();
                Thread.Sleep(650);
                currentTime = DateTime.Now;
            }
        }
        activity.ShowEndMessage();
    }

    private void RandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Think of a time you did something really difficult.",
            "Share a time when you felt stretched beyond your usual limits and what you learned from that experience.",
            "Recall a situation that challenged your beliefs about your capabilities and how it reshaped your perspective.",
            "Describe a moment that required you to dig deep within yourself and the insights gained from overcoming it.",
            "Revisit a difficult task or situation that made you reconsider your strengths and weaknesses, and how it impacted your growth.",
            "Recall a moment when you felt overwhelmed by a difficulty, but ultimately emerged with newfound insights and lessons."
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(prompts[index]);
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.WriteLine();
    }

    private void RandomQuestion()
    {
        List<string> prompts = new List<string>
        {
            ">  How did you feel when it was complete? ",
            ">  What is your favorite thing about this experience? ",
            ">  Could you pinpoint the most fulfilling aspect of this experience for you? ",
            ">  When you completed it, what was the primary sentiment you experienced?",
            ">  What aspect of this completion brought you the most satisfaction?"
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        Console.Write(prompts[index]);
        Console.WriteLine(); //fix so the prompts doesnt repeat again and again
    }
}