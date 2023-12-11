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