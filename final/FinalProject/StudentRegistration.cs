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