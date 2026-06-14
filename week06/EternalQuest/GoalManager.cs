using System;
using System.Collections.Generic;
using System.IO;

// Handles goals, score, and menu system
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nScore: {_score}");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") Save();
            else if (choice == "5") Load();
            else if (choice == "6") break;
            else
                Console.WriteLine("Invalid option.");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, points));

        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, points));

        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        Console.WriteLine("\n--- GOALS ---");
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("\nSelect a goal:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int index))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        index--; // convert to zero-based index

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Selection out of range.");
            return;
        }

        Goal g = _goals[index];

        g.RecordEvent();
        _score += g.GetPoints();

        // Bonus for completed checklist goal
        if (g is ChecklistGoal cg && cg.IsComplete())
        {
            _score += 500;
            Console.WriteLine("Bonus earned!");
        }

        Console.WriteLine("Event recorded!");
    }

    private void Save()
    {
        using (StreamWriter w = new StreamWriter("goals.txt"))
        {
            w.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                w.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved successfully.");
    }

    private void Load()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split("|");

            if (p[0] == "SimpleGoal")
                _goals.Add(SimpleGoal.FromString(p));

            else if (p[0] == "EternalGoal")
                _goals.Add(EternalGoal.FromString(p));

            else if (p[0] == "ChecklistGoal")
                _goals.Add(ChecklistGoal.FromString(p));
        }

        Console.WriteLine("Loaded successfully.");
    }
}