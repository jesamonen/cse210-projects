using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
                break;

            numbers.Add(num);
        }

        // Sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        // Average
        double average = (double)sum / numbers.Count;

        // Max
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
                max = n;
        }

        // Smallest positive
        int smallestPositive = int.MaxValue;
        foreach (int n in numbers)
        {
            if (n > 0 && n < smallestPositive)
                smallestPositive = n;
        }

        // Sort list
        numbers.Sort();

        // Output
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive != int.MaxValue)
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    
    }
}