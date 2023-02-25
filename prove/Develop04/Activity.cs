using System;

class Activity
{
    private int _time;
    private string _explanation;
    private string _finishMessage;
    private string _secondsQuestion = "How long, in seconds, would you like for your session?";
    string _chosedTime;
    int _chosedTimeNumber;

    public Activity(){}


    public Activity (int time)
    {
        _time = time;
    }

    public void StartActivity()
    {

    }

    public void SetExplanation(string explanation)
    {
        _explanation = explanation;
    }

    public string GetExplanation()
    {
        return _explanation;

    }

    public void SetFinish(string finish)
    {
        _finishMessage = finish;
    }

    public string GetFinish()
    {
        return _finishMessage;

    }

        public void SetTime(int time)
    {
        _time = time;
    }

    public int GetTime()
    {
        return _time;

    }

    public int GetSeconds()
    {
        Console.Write(_secondsQuestion);
        _chosedTime = Console.ReadLine();
        _chosedTimeNumber = int.Parse(_chosedTime);
        return _chosedTimeNumber;
    }
    public void Ready()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        for(int i = 0; i<5;i++)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Console.Write("\b \b");

        }


    }




}