using System;

class GamificationProgram
{
    private List<Goal> _lisfOfGoals = new List<Goal>();
    private int _totalPoints;
    private string _nameOfGoalProg;
    private string _descriptionProg;
    private int _pointsToEarnProg;
    private string _pointsToEarnString;
    private string _bonusPointsString;
    private int _bonusPoints;
    private string _timesToAcomplishString;
    private int _timesToAcomplish;
    private bool _statusOfGoal;
    private int _typeOfGoal;
    private string _optionAnswer;
    private int _optionAnswerNumber;
    private string _goalAnswer;
    private string _continue;
    private int _counter = 1;
    private FileManagement _fileManament = new FileManagement();

    //
   // private 
    
    public GamificationProgram()
    {
        do
        {
            Console.Clear();
            Console.WriteLine($"You have {_totalPoints} points.\nMenu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the Menu: ");
            _optionAnswer = Console.ReadLine();
            _optionAnswerNumber = int.Parse(_optionAnswer);
            if(_optionAnswerNumber!= 6)
            {
                switch(_optionAnswerNumber)
                {
                    case 1:
                    CreateNewGoal();
                    break;

                    case 2:
                    if (!_lisfOfGoals.Any())
                    {
                        Console.WriteLine("You do not have any goal so far, please load a file or create new Goals\nPress Enter to Continue");
                        _continue = Console.ReadLine();
                    }
                    else
                    {
                        _counter=1;
                        foreach (Goal goal in _lisfOfGoals)
                        {
                            Console.Write($"{_counter}. ");
                            goal.ShowGoal();
                            _counter++;
                        }
                        Console.Write("Press Enter to Continue");
                        _continue = Console.ReadLine();
                    }
                    
                    break;
                    case 3:
                    
                    break;
                    case 4:
                    
                    break;
                    case 5:
                    
                    break;

                }
            }

        }while (_optionAnswerNumber != 6);
    }
    public void CreateNewGoal()
    {
        Console.Write("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nWhich type of goal would you like to create?: ");
        _goalAnswer = Console.ReadLine();
        _typeOfGoal=int.Parse(_goalAnswer);
        Console.Write("What is the name of your goal?  ");
        _nameOfGoalProg = Console.ReadLine();
        Console.Write("What is a short description of the goal?  ");
        _descriptionProg = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _pointsToEarnString = Console.ReadLine();
        _pointsToEarnProg = int.Parse(_pointsToEarnString);
        if(_typeOfGoal == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            _timesToAcomplishString = Console.ReadLine();
            _timesToAcomplish = int.Parse(_timesToAcomplishString);
            Console.Write("What is the bonus for accomplishing that many times? ");
            _bonusPointsString = Console.ReadLine();
            _bonusPoints = int.Parse(_bonusPointsString);
        }

        switch(_typeOfGoal)
        {
            case 1:
            SimpleGoal _mySimpleGoal = new SimpleGoal(_nameOfGoalProg, _descriptionProg, _pointsToEarnProg);
            _lisfOfGoals.Add(_mySimpleGoal);
            break;

            case 2:
            EternalGoal _myEternalGoal = new EternalGoal(_nameOfGoalProg, _descriptionProg, _pointsToEarnProg);
            _lisfOfGoals.Add(_myEternalGoal);
            break;

            case 3:
            ChecklistGoal _myChecklistGoal = new ChecklistGoal(_nameOfGoalProg, _descriptionProg, _pointsToEarnProg, _timesToAcomplish, _bonusPoints);
            _lisfOfGoals.Add(_myChecklistGoal);
            break;
        }
            
    }
}