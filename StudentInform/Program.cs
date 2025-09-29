using System;
using System.Collections.Generic; // for using List
using System.Linq;

public class StudentInform
{
    static void Main()
    {
        List<int> scores = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter the score for student {i + 1}: ");
            int grade = int.Parse(Console.ReadLine());
            scores.Add(grade);
        }

        int maxScore = scores.Max();
        int minScore = scores.Min();
        double avgScore = scores.Average();

        Console.WriteLine($"Highest score: {maxScore}");
        Console.WriteLine($"Lowest score: {minScore}");
        Console.WriteLine($"Average score: {avgScore:F2}");
    }
}
