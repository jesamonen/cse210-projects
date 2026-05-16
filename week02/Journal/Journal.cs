using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // ADD ENTRY
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // DISPLAY ALL
    public void DisplayAll()
    {
        Console.WriteLine();

        Console.WriteLine($"Total Entries: {_entries.Count}");
        Console.WriteLine();

        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // SAVE FILE
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._mood}");
            }
        }
    }

    // LOAD FILE
    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entry._mood = parts[3];

            _entries.Add(entry);
        }

        Console.WriteLine();
        Console.WriteLine("Journal Loaded Successfully.");
        Console.WriteLine();

        DisplayAll();
    }
}