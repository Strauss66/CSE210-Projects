using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddingEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public List<Entry> ReadFileInfo(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            Entry entry = new Entry
            {
                _prompt = parts[0],
                _content = parts[1],
                _date = parts[2]
            };
            loadedEntries.Add(entry);
        }

        return loadedEntries;
    }

    public void WriteFileInfo(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.SaveText());
            }
        }
    }
}
