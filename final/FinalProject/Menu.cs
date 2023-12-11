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