using System;

class GamificationProgram
{
    private List<Goal> _listOfGoals = new List<Goal>();
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
    private int _counterEvent = 1;
    private string _acomplishAnswerString;
    private int _acomplishAnswer;
    private FileManagement _fileManament = new FileManagement();
    private List<string> _conversionList = new List<string>();
    
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
                    if (!_listOfGoals.Any())
                    {
                        Console.WriteLine("You do not have any goal so far, please load a file or create new Goals\nPress Enter to Continue");
                        _continue = Console.ReadLine();
                    }
                    else
                    {
                        _counter=1;
                        foreach (Goal goal in _listOfGoals)
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
                    ConvertGoals();
                    
                    break;
                    case 4:
                    
                    break;

                    case 5:
                    RecordEvents();
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
            _listOfGoals.Add(_mySimpleGoal);
            break;

            case 2:
            EternalGoal _myEternalGoal = new EternalGoal(_nameOfGoalProg, _descriptionProg, _pointsToEarnProg);
            _listOfGoals.Add(_myEternalGoal);
            break;

            case 3:
            ChecklistGoal _myChecklistGoal = new ChecklistGoal(_nameOfGoalProg, _descriptionProg, _pointsToEarnProg, _timesToAcomplish, _bonusPoints);
            _listOfGoals.Add(_myChecklistGoal);
            break;
        }
    }

    public void RecordEvents()
    {
        _counterEvent = 1;
        Console.WriteLine("The Goals are:");
        foreach(Goal goal in _listOfGoals)
        {
            Console.WriteLine($"{_counterEvent}.- {goal.GetNameOfGoal()}");
            _counterEvent++;
        }
        Console.Write("Which Goal did you Accomplish? ");
        _acomplishAnswerString = Console.ReadLine();
        _acomplishAnswer = int.Parse(_acomplishAnswerString);
        if(_listOfGoals[_acomplishAnswer-1].GetStatusOfGoal())
        {
            Console.WriteLine("You Already Completed this goal\nPress Enter to Continue"); 
            _continue = Console.ReadLine();   
        }
        else
        {
            _listOfGoals[_acomplishAnswer-1].RecordEvent();
            Console.WriteLine($"Congratulations! You have earned {_listOfGoals[_acomplishAnswer-1].GetPointsToEarn()} points!\nPress Enter to Continue");
            _totalPoints = _totalPoints + _listOfGoals[_acomplishAnswer-1].GetPointsToEarn();
            _continue = Console.ReadLine();  
        }
    }

    public void ConvertGoals()
    {
        _conversionList.Clear();
        foreach (Goal goal in _listOfGoals)
        {
            if(goal.GetTypeOfGoal() == "SimpleGoal")
            {
                _conversionList.Add($"{goal.GetTypeOfGoal()}:{goal.GetNameOfGoal()}:{goal.GetPointsToEarn()}:{goal.GetStatusOfGoal()}");
            }
            else if(goal.GetTypeOfGoal() == "EternalGoal")
            {
                _conversionList.Add($"{goal.GetTypeOfGoal()}:{goal.GetNameOfGoal()}:{goal.GetPointsToEarn()}");
            }
            else if (goal.GetTypeOfGoal() == "ChecklistGoal")
            {
                _conversionList.Add($"{goal.GetTypeOfGoal()}:{goal.GetNameOfGoal()}:{goal.GetPointsToEarn()}:{goal.GetStatusOfGoal()}:{goal.GetBonusPoints}:{goal.GetTimesToAcomplish}:{goal.GetTimesAcomplished}");
            }
        }
    }
}