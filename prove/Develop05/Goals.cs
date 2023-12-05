using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    // Note: You might want to consider making these properties instead of using fields.
    public static List<Goals> listOfGoals = new List<Goals>();
    protected string _goal;
    protected string _goalDescription;
    protected double _points;

    public virtual void Goal()
    {
        Console.WriteLine("What is the name of your goal?");
        string goal = Console.ReadLine();
        SetGoal(goal);
        Console.WriteLine("What is a description of it?");
        string goalDescription = Console.ReadLine();
        SetDescription(goalDescription);
        Console.WriteLine("What is the amount of points associated with this goal?");
        string po = Console.ReadLine();
        double points = Convert.ToDouble(po);
        SetPoints(points);
        SaveText();
        DisplayListItems(); // Display the list after adding a new goal.
    }

    public void DisplayListItems()
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in listOfGoals)
        {
            Console.WriteLine($"{goal._goal} - {goal._goalDescription} - {goal._points}");
        }
    }

    public virtual void SaveText()
    {
        listOfGoals.Add(this);
        var text = $"{_goal}~{_goalDescription}~{_points}~0";
    }

    public void SetGoal(string goal)
    {
        _goal = goal;
    }

    public string GetGoal()
    {
        return _goal;
    }

    public void SetDescription(string description)
    {
        _goalDescription = description;
    }

    public string GetDescription()
    {
        return _goalDescription;
    }

    public double GetPoints()
    {
        return _points;
    }

    public void SetPoints(double points)
    {
        _points = points;
    }

    public static List<Goals> ReadList()
    {
        List<Goals> goals = new List<Goals>();
        foreach (string line in File.ReadAllLines("goals.txt"))
        {
            string[] parts = line.Split('~');
            Goals goal = new Goals();
            goal.SetGoal(parts[0]);
            goal.SetDescription(parts[1]);
            goal.SetPoints(Convert.ToDouble(parts[2]));
            goals.Add(goal);
        }
        return goals;
    }
}
