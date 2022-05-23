using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!grades.ContainsKey(studentName))
                {
                    grades.Add(studentName, new List<decimal>());
                }

                grades[studentName].Add(grade);
            }

            foreach (var grade in grades)
            {
                Console.WriteLine($"{grade.Key} -> {string.Join(" ", grade.Value.Select(x => x.ToString("F2")))} (avg: {grade.Value.Average():f2})");
            }
        }
    }
}
