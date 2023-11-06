public class ListingActivity
{
    Activity activity = new Activity();
    public void ListActivity()
    {
        activity.ShowStartMessage();
        Console.WriteLine("This activity will help you reflect on the good things on your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();
        activity.GetTime();
        
        Console.WriteLine("Get ready... ");
        activity.ShowAnimation();
        Console.Clear();
        RandomPrompt();
        int count = 0;
        
        int duration = activity.TimeGetter();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
            {
                string answer = "answer";
                if (answer != "")
                {
                    Console.Write("> ");
                    answer = Console.ReadLine();
                    count += 1;
                }
                currentTime = DateTime.Now;
            }
        Console.WriteLine($"You listed {count} items!");
        activity.ShowEndMessage();
    }

    private void RandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "---- When have you felt the holy ghost this month? ----",
            "---- Can you share a recent moment that profoundly connected you with God? ----",
            "---- When have you felt the blessings of God this week? ----",
            "---- Have you recently witnessed or experienced something that made you feel especially grateful or blessed? ----"
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        Console.WriteLine("List as many response as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompts[index]);
        Console.WriteLine("");
        activity.CountDown("You may begin in: ", 6);
        Console.WriteLine();
    }
    
}