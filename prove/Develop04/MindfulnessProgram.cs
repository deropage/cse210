using System;

class MindfulnessProgram
{
    private string _answer;
    private int _numberAnswer;
    private int _activityTime;

    public MindfulnessProgram ()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit");
            _answer = Console.ReadLine();
            if(_answer != "quit")
            {
                _numberAnswer=int.Parse(_answer);
                switch(_numberAnswer)
                {
                    case 1:
                    BreathingActivity _breathActivity = new BreathingActivity();
                    break;
                }
            }
        }while(_answer != "quit");
    }


}