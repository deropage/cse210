using System;

class Program
{
    static void Main(string[] args)
    {
        string tryAgain = "Yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(0,1000);
            int count = 0;
            int? guessNumber = null;
            while ( magicNumber != guessNumber)
            {
                count += 1;
                Console.Write("What is your guess? ");
                string tempGuessNumber = Console.ReadLine();
                guessNumber = int.Parse(tempGuessNumber);
                if (magicNumber == guessNumber)
                {
                    Console.WriteLine($"You guessed it after {count} tries.");
                    Console.WriteLine("Do you want to try again?");
                    tryAgain = Console.ReadLine();
                
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine($"Lower \nYou have tried {count} times.");
                }
                else 
                {
                    Console.WriteLine($"Higher \nYou have tried {count} times.");
                }
            }
        }while (tryAgain == "Yes");

            
    }
}