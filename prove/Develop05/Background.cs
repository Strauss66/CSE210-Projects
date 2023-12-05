public class Background
{
    ChecklistGoal cg = new ChecklistGoal();
    Goals g = new Goals();

    public void Planned()
    {
        Console.Clear();
        Console.WriteLine("The type of goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        string answer = Console.ReadLine();
        switch (answer)
        {
            case "1":
                g.Goal();
                break;
            case "2":
                //
                break;
            case "3":
                cg.Goal();
                break;
            default:
                Console.WriteLine("Pick an available option.");
                break;
        } 
    }
}