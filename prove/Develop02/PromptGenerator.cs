using System;

public class PromptGenerator
{
    public List<string> _listOfQuestions = new List<string>();
    public List<string> _questionsDone = new List<string>();

    public PromptGenerator()
    {

    }

    public void RandomQuestion()
    {
        List<string> mainList = new List<string>();
        Random rndQuestion = new Random();

        mainList.Add("Who was the most interesting conversation you had today?");
        mainList.Add("What was the best part of my day?");
        mainList.Add("How did I see the hand of the Lord in my life today");
        mainList.Add("What was the stronger emotion I felt today");
        mainList.Add("If I had one thing I could do over today, what would it be?");
        mainList.Add("What did you achieve today?");
        mainList.Add("What places you were today?");
        mainList.Add("What would you do better today?");
        mainList.Add("How did you connect with your loved ones today?");
        mainList.Add("Which questions you did not answer today?");

        for (int counter = 0; counter < 9; counter++)
        {
            _listOfQuestions.Add(mainList[rndQuestion.Next(10)]);
        }
    }
}