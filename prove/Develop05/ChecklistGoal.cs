public class ChecklistGoal : Goals
{
    int _goalTime;
    public override void Goal()
    {
        base.Goal();
        Console.WriteLine("How many times does this goal need to be accomplished in order to get the bonus point?");
        var ntimes = Console.ReadLine();
        int times = int.Parse(ntimes);
        SetGoalTime(times);
    } 

    public void SetGoalTime(int times)
    {
        _goalTime = times;
    }
    public int GetGoalTime()
    {
        return _goalTime;
    }
    public override void SaveText()
    {
        base.SaveText();
        listOfGoals.Add(this);
        var text = $"{_goal}~{_goalDescription}~{_points}~{_goalTime}";
    }
}