using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numerical grade (0-100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                    return;
                }

                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"The Corresponding letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90) return "A";
            else if (grade >= 80) return "B";
            else if (grade >= 70) return "C";
            else if (grade >= 60) return "D";
            else return "F";
        }
    }
}
