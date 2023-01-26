using System;

public class Entry
{
    public List<string> _answersFromPrompt = new List<String>();
    public PromptGenerator mainPrompt = new PromptGenerator();
    public int questionIndex = 0;
    
    public Entry() 
    {
        mainPrompt.RandomQuestion();
    }

    public void NewEntry()
    {
        if (questionIndex >= 10)
        {
            
            Console.WriteLine("There are no more questions for today\nDo you want to write something else? y/n");
            string moreEntries = Console.ReadLine();
            if (moreEntries == "y")
            {
                DateTime now = DateTime.Now;
                string date = now.ToString("F");
                Console.WriteLine("Please write your Entry");
                string answer = Console.ReadLine();
                _answersFromPrompt.Add("Date: " + date + " - Prompt: Personalized Entry" + "\n" + answer);
                mainPrompt._askedQuestions.Add(questionIndex);
            }

        }
        else
        {
            DateTime now = DateTime.Now;
            string date = now.ToString("F");   
            Console.WriteLine(mainPrompt._listOfQuestions[questionIndex]);
            string answer = Console.ReadLine();
            _answersFromPrompt.Add("Date: " + date + " - Prompt: " + mainPrompt._listOfQuestions[questionIndex] + "\n" + answer);
            mainPrompt._askedQuestions.Add(questionIndex);
            questionIndex++;

        } 

    }

}
