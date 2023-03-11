using System;

class ChecklistGoal : Goal
{
    private int _timesToAcomplish;
    private int _timesAcomplished;
    private int _bonusPoints;
    public ChecklistGoal(string nameOfGoal, string description, int pointsToEarn, int times, int bonus):base(nameOfGoal, description,pointsToEarn)
    {
        _timesToAcomplish = times;
        _bonusPoints = bonus;

    }

    public void SetTimesToAcomplish(int timesTo)
    {
        _timesToAcomplish = timesTo;
    }
    public int GetTimesToAcomplish()
    {
        return _timesToAcomplish;
    }

    public void SetTimesAcomplished()
    {
        _timesAcomplished ++;
    }
    public int GetTimesAcomplished()
    {
        return _timesAcomplished;
    }
    public void SetBonusPoints(int bonus)
    {
        _bonusPoints = bonus;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    

    public override void ShowGoal()
    {
        if(GetStatusOfGoal()){SetStatusOfGoalPrint("X");}
        else{ SetStatusOfGoalPrint(" ");}
        Console.WriteLine($"[{GetStatusOfGoalPrint()}] {GetNameOfGoal()} ({GetDescription()}) -- Currently complete: {_timesAcomplished}/{_timesToAcomplish}");
    }

    public override void RecordEvent()
    {
        SetTimesAcomplished();
        if(GetTimesAcomplished() == GetTimesToAcomplish())
        {
            SetStatusOfGoal(true);
        }
    }
}