using System;

class BreathingActivity : Activity
{
    private int _timesBreathing;
    private int _timeBreathing;
    public BreathingActivity()
    {
      
    }


    public BreathingActivity(int time) : base(time)
    {
        SetTime(time);
    }

    public void Breath()
    {

    }

}