using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string tempNumber = Console.ReadLine();
            int number = int.Parse(tempNumber);
            return number;
        }

        static int SquareNumber(int basenumber)
        {
            int square = basenumber * basenumber;
            return square;
        }

        static void DisplayResult(string nameResult, double squareResult)
        {
            Console.WriteLine($"{nameResult}, the square of your number is {squareResult}");
        }
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

    }
}