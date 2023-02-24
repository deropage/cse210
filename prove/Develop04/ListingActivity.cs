using System;

class ListingActivity : Activity
{
    private List <string> _questions = new List<string>();
    private List <string> _answers= new List<string>();

    public ListingActivity(int time) : base(time)
    {
        SetTime(time);
    }

    public void List()
    {
        
    }

}