using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var menu = new Menu();
        menu.Display();
    }
}

public class Menu
{
    private List<User> studentRegistrations = new List<User>();
    private const string FilePath = "student_registrations.csv";

    public void Display()
    {   
        Console.WriteLine("Welcome to the Student Registration System!");
        Console.WriteLine("==========================================");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Add a Student");
        Console.WriteLine("2. Save Student Registrations");
        Console.WriteLine("3. Load Student Registrations");
        Console.WriteLine("4. View Student Lists");
        Console.WriteLine("5. Exit");

        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                AddStudent();
                Display();
                break;
            case "2":
                SaveRegistrations();
                Display();
                break;
            case "3":
                LoadRegistrations();
                Display();
                break;
            case "4":
                ViewStudentLists();
                Display();
                break;
            case "5":
                //
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                Display();
                break;
        }
    }

    private void AddStudent()
    {
        Console.WriteLine("Enter student details:");

        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Course: ");
        string course = Console.ReadLine();

        Console.Write("Student Type (1. Kindergarten, 2. Primary, 3. Secondary, 4. High School): ");
        int studentType = int.Parse(Console.ReadLine());

        double fee = 0;

        switch (studentType)
        {
            case 1:
                fee = new KindergartenStudent().GetFee();
                break;
            case 2:
                fee = new PrimaryStudent().GetFee();
                break;
            case 3:
                fee = new SecondaryStudent().GetFee();
                break;
            case 4:
                fee = new HighSchoolStudent().GetFee();
                break;
            default:
                Console.WriteLine("Invalid student type.");
                return;
        }

        var student = new User { Id = id, Name = name, Course = course, Fee = fee, LateFee = 0 };
        studentRegistrations.Add(student);

        Console.WriteLine("Student added successfully!");
    }

    private void SaveRegistrations()
    {
        var studentRegistration = new StudentRegistration();
        studentRegistration.SaveToCsv(studentRegistrations, FilePath);

        Console.WriteLine();
        Console.WriteLine($"Student registrations saved to '{FilePath}'.");
        Console.WriteLine();
    }

    private void LoadRegistrations()
    {
        Console.WriteLine();
        var studentRegistration = new StudentRegistration();
        var loadedRegistrations = studentRegistration.LoadFromCsv(FilePath);
    
        if (loadedRegistrations != null)
        {
            studentRegistrations = loadedRegistrations;
            Console.WriteLine($"-----Student registrations loaded from '{FilePath}'.");
        }
        else
        {
            Console.WriteLine($"-----Unable to load student registrations from '{FilePath}'.");
        }
        Console.WriteLine();
    }

    private void ViewStudentLists()
    {
        var studentList = new StudentList(studentRegistrations);
        studentList.Display();
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public double Fee { get; set; }
    public double LateFee { get; set; }
}

public class StudentRegistration
{
    public void SaveToCsv(IEnumerable<User> registrations, string filePath)
    {
        var csvContent = new List<string>
        {
            "Id,Name,Course,Fee,LateFee"
        };

        foreach (var registration in registrations)
        {
            csvContent.Add($"{registration.Id},{registration.Name},{registration.Course},{registration.Fee},{registration.LateFee}");
        }

        File.WriteAllLines(filePath, csvContent);
    }

    public List<User> LoadFromCsv(string filePath)
    {
        try
        {
            var lines = File.ReadAllLines(filePath);
            var registrations = new List<User>();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var user = new User
                {
                    Id = int.Parse(values[0]),
                    Name = values[1],
                    Course = values[2],
                    Fee = double.Parse(values[3]),
                    LateFee = double.Parse(values[4])
                };
                registrations.Add(user);
            }

            return registrations;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filePath}' not found.");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading registrations: {ex.Message}");
            return null;
        }
    }
}

public class StudentList
{
    private readonly List<User> studentRegistrations;

    public StudentList(List<User> studentRegistrations)
    {
        this.studentRegistrations = studentRegistrations;
    }

    public void Display()
    {
        Console.WriteLine("Student List:");
        Console.WriteLine("Id\tName\tCourse\tFee\tLateFee");

        foreach (var student in studentRegistrations)
        {
            Console.WriteLine($"{student.Id}\t{student.Name}\t{student.Course}\t{student.Fee}\t{student.LateFee}");
        }

        Console.WriteLine("Press Enter to go back to the Main Menu...");
        Console.ReadLine();
    }
}


public class Student
{
    public virtual double GetFee()
    {
        return 0;
    }
}

public class KindergartenStudent : Student
{
    public override double GetFee()
    {
        return 1000;
    }
}

public class PrimaryStudent : Student
{
    public override double GetFee()
    {
        return 2500;
    }
}

public class SecondaryStudent : Student
{
    public override double GetFee()
    {
        return 3000;
    }
}

public class HighSchoolStudent : Student
{
    public override double GetFee()
    {
        return 4000;
    }
}