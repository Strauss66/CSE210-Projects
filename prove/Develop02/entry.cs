public class Entry
{
    public string _prompt = "";
    public string _content = "";
    public string _date = "";

    public void DisplayEntry()
    {
        Console.WriteLine($"{_prompt}  {_content}  {_date}");
    }
    public string SaveText()
    {
        return $"{_prompt}~{_content}~{_date}";
    }
}