using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        string tempMagicNumber = Console.ReadLine();
        int magicNumber = int.Parse(tempMagicNumber);
        int? guessNumber = null;

        while ( magicNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            string tempGuessNumber = Console.ReadLine();
            guessNumber = int.Parse(tempGuessNumber);

            if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("Higher");
            }
        }
            

    }
}