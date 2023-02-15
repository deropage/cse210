using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment _newAssignment = new Assignment("Samuel Bennet", "Multiplication"); // Base Class
        Console.WriteLine(_newAssignment.GetSummary());

        MathAssignment _newMathAssignment = new MathAssignment ("Roberto Rodriguez", "Fractions", "7.3", "8-19"); // Math Assignment
        Console.WriteLine(_newMathAssignment.GetSummary());
        Console.WriteLine(_newMathAssignment.GetHomeworkList());

        WritingAssignment _newWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II"); // Writing Assignment
        Console.WriteLine(_newWritingAssignment.GetSummary());
        Console.WriteLine(_newWritingAssignment.GetWritingInformation());

    }
}