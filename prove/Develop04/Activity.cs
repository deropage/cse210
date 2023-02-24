using System;

class Activity
{
    private int _time;
    private string _explanation;
    private string _finishMessage;

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

        public void SetTime(int time)
    {
        _time = time;
    }

    public int GetTime()
    {
        return _time;

    }


}