using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = " ";
        string letterGradeSign = " ";
        Console.Write("Hello Please Enter you Grade: ");
        string inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);
       

        if (grade >= 90 && grade <= 100)
        {
            letterGrade = "A";
        }

        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }

        else if (grade >=70 && grade <80)
        { 
            letterGrade = "C";
        }

        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D"; 
        }

        else if (0 <= grade && grade < 60)
        {
            letterGrade = "F";
        }

        else
        {
            Console.WriteLine("Invalid grade");
        }

        if (grade < 97 && grade >= 60)
        {
            if (grade%10 >= 7)
            {
                letterGradeSign = "+";
            }
            else if (grade%10 < 3)
            {
                letterGradeSign = "-";
            }
            else
            {
                letterGradeSign = "";
            }
        }

        Console.WriteLine($"Your grade is {letterGrade}{letterGradeSign}.");
        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.Write("Congratulations! You passed the Course");
        }
        else if (letterGrade == "D" || letterGrade == "F")
        {
            Console.Write("Sorry you have not passed the course, try harder next time");
        }
        else
        {
            Console.Write("Please enter a valid grade from 0 - 100");
        }

    }
}