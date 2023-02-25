using System;

class BreathingActivity : Activity
{
    private int _timesBreathing;
    private int _timeBreathing;
    public BreathingActivity()
    {
        SetExplanation("This Activity will help you relax by walking thrugh breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetFinish($"You have completed {GetTime()} seconds of the Breathing Activity");
        Breath(GetTime());
        SetFinish($"You have completed {GetTime()} seconds of the Breathing Activity");
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity\n");
        Console.WriteLine($"{GetExplanation()}\n");
        SetTime(GetSeconds());
        Ready();
        Breath(GetTime());
      
    }



    public void Breath(int time)
    {
        _timeBreathing = _timeBreathing + GetTime();
        _timesBreathing++;
        
        
        


    }



}