using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt1 = new PromptGenerator();
        prompt1.RandomQuestion();
        foreach (var prompt in prompt1._listOfQuestions)
        {
            Console.WriteLine(prompt);
        }
    }
}