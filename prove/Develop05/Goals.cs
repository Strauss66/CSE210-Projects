public class Goals
{
    public List<string> listOfGoals = new List<string>();
    public void planned()
    {
        Console.Clear();
        Console.WriteLine("The type of goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        string answer = Console.ReadLine();
        switch (answer)
            {
                case "1":
                    simpleGoal();
                    break;
                case "2":
                    //
                    break;
                case "3":
                    //
                    break;
            }
    }
    public void simpleGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        string goal = Console.ReadLine();
        Console.WriteLine("What is a description of it?");
        string goalDescription = Console.ReadLine();
        var goalFile = $"{goal}~{goalDescription}";
        listOfGoals.Add(goalFile);
    }
}
public class EternalGoals : Goals
{
    simpleGoal
}