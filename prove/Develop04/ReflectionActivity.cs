using System;

class ReflectionActivity : Activity
{
    private List <string> _questions = new List<string>();
    private List <string> _answers= new List<string>();

    public ReflectionActivity(int time) : base(time)
    {
        SetTime(time);
    }

    public void Reflect()
    {
        
    }

}