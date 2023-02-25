using System;

class MindfulnessProgram
{
    private string _answer;
    private int _numberAnswer;


    public MindfulnessProgram ()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit");
            _answer = Console.ReadLine();
            _numberAnswer=int.Parse(_answer);
            if(_numberAnswer != 4)
            {
            
                switch(_numberAnswer)
                {
                    case 1:
                    BreathingActivity _breathActivity = new BreathingActivity();
                    
                    break;
                }
            }
        }while(_numberAnswer != 4);
    }




}